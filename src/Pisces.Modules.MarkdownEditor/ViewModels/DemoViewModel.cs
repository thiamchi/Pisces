using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Pisces.Framework;
using Pisces.Modules.MarkdownEditor.Views;

namespace Pisces.Modules.MarkdownEditor.ViewModels
{
    [Export]
    public class DemoViewModel : PersistedDocument, INotifyPropertyChanged
    {
        private DemoView _view;
        private string _originalText;

        private string _DemoMD;
        public string DemoMd
        {
            get { return _DemoMD; }
            set
            {
                _DemoMD = value;
                NotifyOfPropertyChange(() => DemoMd);
            }
        }

        public ICommand OnHyperlink { get; }

        public DemoViewModel()
        {
            DisplayName = "Demonstration Document Viewer";

            OnHyperlink = new DelegateCommand(link =>
            {
                if (link is string input)
                {
                    bool isProcess = false;
                    //MessageBox.Show(input);
                    try
                    {
                        DemoMd = File.ReadAllText(input);
                    }
                    catch
                    {
                        isProcess = true;
                        MessageBox.Show(".md file not found or provided link is not .md");
                    }

                    try
                    {
                        if (isProcess) Process.Start(input);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            });
        }

        public override bool ShouldReopenOnStart
        {
            get { return true; }
        }

        protected override Task DoNew()
        {
            DemoMd = @"
*Demo text*

[Open cmd](cmd)

[Open notepad](notepad)

[Open google](https://www.google.com)

1. hallo
2. how
3. are you

> Note";
            _originalText = DemoMd;
            ApplyOriginalText();
            return Task.FromResult(true);
        }

        protected override Task DoLoad(string filePath)
        {
            DemoMd = File.ReadAllText(filePath);
            _originalText = DemoMd;
            ApplyOriginalText();
            return Task.FromResult(true);
        }

        protected override Task DoSave(string filePath)
        {
            File.WriteAllText(filePath, DemoMd);
            _originalText = DemoMd;
            return Task.FromResult(true);
        }

        private void ApplyOriginalText()
        {
            _view.editor.DataContextChanged += delegate
            {
                IsDirty = string.Compare(_originalText, DemoMd) != 0;
            };
        }

        protected override void OnViewLoaded(object view)
        {
            _view = (DemoView)view;
        }
    }
}