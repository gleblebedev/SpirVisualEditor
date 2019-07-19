using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Media;
using Veldrid;
using PixelFormat = Veldrid.PixelFormat;

namespace SpirVisualEditor.Controls
{
    public class VeldridComponent : Win32HwndControl
    {
        private CommandList _cl;
        private GraphicsDevice _gd;
        private Swapchain _sc;

        public bool Rendering { get; private set; }

        protected sealed override void Initialize()
        {
            _gd = GraphicsDevice.CreateD3D11(new GraphicsDeviceOptions());
            _cl = _gd.ResourceFactory.CreateCommandList();
            CreateSwapchain();

            Rendering = true;
            CompositionTarget.Rendering += OnCompositionTargetRendering;
        }

        protected sealed override void Uninitialize()
        {
            Rendering = false;
            CompositionTarget.Rendering -= OnCompositionTargetRendering;

            DestroySwapchain();
        }

        protected sealed override void Resized()
        {
            ResizeSwapchain();
        }

        private void OnCompositionTargetRendering(object sender, EventArgs eventArgs)
        {
            if (!Rendering)
                return;

            Render();
        }

        private double GetDpiScale()
        {
            var source = PresentationSource.FromVisual(this);

            return source.CompositionTarget.TransformToDevice.M11;
        }

        protected virtual void CreateSwapchain()
        {
            var dpiScale = GetDpiScale();
            var width = (uint) (ActualWidth < 0 ? 0 : Math.Ceiling(ActualWidth * dpiScale));
            var height = (uint) (ActualHeight < 0 ? 0 : Math.Ceiling(ActualHeight * dpiScale));

            var mainModule = typeof(VeldridComponent).Module;
            var hinstance = Marshal.GetHINSTANCE(mainModule);
            var win32Source = SwapchainSource.CreateWin32(Hwnd, hinstance);
            var scDesc = new SwapchainDescription(win32Source, width, height, PixelFormat.R32_Float, true);

            _sc = _gd.ResourceFactory.CreateSwapchain(scDesc);
        }

        protected virtual void DestroySwapchain()
        {
            _sc.Dispose();
        }

        private void ResizeSwapchain()
        {
            var dpiScale = GetDpiScale();
            var width = (uint) (ActualWidth < 0 ? 0 : Math.Ceiling(ActualWidth * dpiScale));
            var height = (uint) (ActualHeight < 0 ? 0 : Math.Ceiling(ActualHeight * dpiScale));
            _sc.Resize(width, height);
        }

        protected virtual void Render()
        {
            _cl.Begin();
            _cl.SetFramebuffer(_sc.Framebuffer);
            var r = new Random();
            _cl.ClearColorTarget(
                0,
                new RgbaFloat(0, 0, 0, 1)); //(float)r.NextDouble()
            _cl.ClearDepthStencil(1);

            // Do your rendering here (or call a subclass, etc.)

            _cl.End();
            _gd.SubmitCommands(_cl);
            _gd.SwapBuffers(_sc);
        }
    }
}