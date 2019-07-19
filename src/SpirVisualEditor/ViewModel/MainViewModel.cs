using System;
using System.IO;
using Microsoft.Win32;
using SpirVGraph;
using Toe.Scripting.WPF;
using Toe.Scripting.WPF.ViewModels;

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
            ofd.Filter = "SpirV (*.spv) | *.spv";
            if (ofd.ShowDialog() == true)
            {
                FileName = ofd.FileName;
                ScriptViewModel.Script = SpirVConverter.Deserialize(File.ReadAllBytes(FileName));
                ScriptViewModel.ResetUndoStack();
                ScriptViewModel.HasUnsavedChanged = false;
            }
        }
    }
}