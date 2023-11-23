using System.ComponentModel;

namespace Wpf_WS
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _mainTitle;
        private string _textBoxText;
        private string _blockText;
        private string _inputText;


        public MainViewModel()
        {
            MainTitle = "Hello MVVM";
            BlockText = "placeHolder";
            InputText = "Text a transformer";
        }

        public string InputText
        {
            get => _inputText;
            set { if (_inputText != value) { _inputText = value; OnPropertyChanged(nameof(InputText)); } }
        }

        public string MainTitle
        {
            get => _mainTitle;
            set { if (_mainTitle != value) { _mainTitle = value; OnPropertyChanged(nameof(MainTitle)); } }
        }


        public string TextBoxText
        {
            get { return _textBoxText; }
            set
            {
                if (_textBoxText != value)
                {
                    _textBoxText = value;
                    OnPropertyChanged(nameof(TextBoxText));
                }
            }
        }

        public string BlockText
        {
            get => _blockText;
            set
            {
                if (_blockText != value)
                {
                    _blockText = value;
                    OnPropertyChanged(nameof(BlockText));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
