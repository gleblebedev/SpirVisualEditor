using System;
using System.IO;
using Microsoft.Win32;
using SpirVGraph;
using Toe.Scripting.WPF;
using Toe.Scripting.WPF.ViewModels;
using Veldrid;
using Veldrid.SPIRV;

namespace SpirVisualEditor.ViewModel
{
    public class MainViewModel : ViewModelBase, IDisposable
    {
        private string _fileName;

        public MainViewModel(ScriptViewModel scriptViewModel)
        {
            ScriptViewModel = scriptViewModel;
            OpenCommand = new ScriptingCommand(Open);
        }

        public string FileName
        {
            get => _fileName;
            set => RaiseAndSetIfChanged(ref _fileName, value);
        }

        public ScriptingCommand OpenCommand { get; set; }

        public ScriptViewModel ScriptViewModel { get; set; }

        public void Dispose()
        {
        }

        private void Open()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "SpirV (*.spv)|*.spv|Vertex Shader (*.vert.glsl)|*.vert.glsl|Fragment Shader (*.frag.glsl)|*.frag.glsl";
            if (ofd.ShowDialog() == true)
            {
                FileName = ofd.FileName;
                byte[] bytes;
                if (FileName.EndsWith(".vert.glsl"))
                {
                    bytes = SpirvCompilation.CompileGlslToSpirv(File.ReadAllText(FileName), FileName, ShaderStages.Vertex, GlslCompileOptions.Default).SpirvBytes;
                }
                else if (FileName.EndsWith(".frag.glsl"))
                {
                    bytes = SpirvCompilation.CompileGlslToSpirv(File.ReadAllText(FileName), FileName, ShaderStages.Fragment, GlslCompileOptions.Default).SpirvBytes;
                }
                else
                {
                    bytes = File.ReadAllBytes(FileName);
                }
                ScriptViewModel.Script = SpirVConverter.Deserialize(bytes);
                ScriptViewModel.ResetUndoStack();
                ScriptViewModel.HasUnsavedChanged = false;
            }
        }
    }
}