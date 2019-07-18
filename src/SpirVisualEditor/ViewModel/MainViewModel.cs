using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Newtonsoft.Json;
using SpirVGraph;
using Toe.Scripting;
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

        public string FileName
        {
            get { return _fileName; }
            set
            {
                RaiseAndSetIfChanged(ref _fileName, value);
            }
        }

        public ScriptingCommand OpenCommand { get; set; }

        public ScriptViewModel ScriptViewModel { get; set; }

        public void Dispose()
        {
        }
    }
}
