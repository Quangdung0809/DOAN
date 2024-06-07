using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ThietKeSan
{
    public class FormData : INotifyPropertyChanged
    { // Định nghĩa các biến thành viên
        #region 'Event'

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion 'Event'
        private View.MainView _mainWindow;

        public View.MainView MainWindow
        {
            get
            {
                return new View.MainView(SingleData.Singleton.Instance.RevitData.Document);
            }
            set
            {
                _mainWindow = new View.MainView(SingleData.Singleton.Instance.RevitData.Document);
            }
        }
        private View.Frm_ThongTinSan _Thongtinsan;

        public View.Frm_ThongTinSan Thongtinsan
        {
            get
            {
                return new View.Frm_ThongTinSan();
            }
            set
            {
                _Thongtinsan = new View.Frm_ThongTinSan();
            }
        }
        private View.Frm_VatLieu _vatlieu;

        public View.Frm_VatLieu FormVatLieu
        {
            get
            {
                return new View.Frm_VatLieu();
            }
            set
            {
                _vatlieu = new View.Frm_VatLieu();
            }
        }
        private View.Form_ThuyetMinh _thuyetminh;

        public View.Form_ThuyetMinh FormThuyetMinh
        {
            get
            {
                return new View.Form_ThuyetMinh();
            }
            set
            {
                _thuyetminh = new View.Form_ThuyetMinh();
            }
        }
        private View.Frm_ThemLopVatLieu _themvatlieu;

        public View.Frm_ThemLopVatLieu ThemVatLieu
        {
            get
            {
                return new View.Frm_ThemLopVatLieu();
            }
            set
            {
                _themvatlieu = new View.Frm_ThemLopVatLieu();
            }
        }
        private View.Frm_TaiTrong _taitrong;

        public View.Frm_TaiTrong FormTaiTrong
        {
            get
            {
                return new View.Frm_TaiTrong();
            }
            set
            {
                _taitrong = new View.Frm_TaiTrong();
            }
        }
        private View.Frm_BoTriThep _botrithep;

        public View.Frm_BoTriThep Botrithep
        {
            get
            {
                return new View.Frm_BoTriThep();
            }
            set
            {
                _botrithep = new View.Frm_BoTriThep();
            }
        }
        private View.Frm_ThemHT _hoattai;

        public View.Frm_ThemHT FormHoatTai
        {
            get
            {
                return new View.Frm_ThemHT();
            }
            set
            {
                _hoattai = new View.Frm_ThemHT();
            }
        }
        private View.Frm_ThemTT _tinhtai;

        public View.Frm_ThemTT FormTinhTai
        {
            get
            {
                return new View.Frm_ThemTT();
            }
            set
            {
                _tinhtai = new View.Frm_ThemTT();
            }
        }
        public class RelayCommand<T> : ICommand
        {
            private readonly Predicate<T> _canExecute;
            private readonly Action<T> _execute;

            public RelayCommand(Predicate<T> canExecute, Action<T> execute)
            {
                if (execute == null)
                    throw new ArgumentNullException("execute");
                _canExecute = canExecute;
                _execute = execute;
            }

            public bool CanExecute(object parameter)
            {
                try
                {
                    return _canExecute == null ? true : _canExecute((T)parameter);
                }
                catch
                {
                    return true;
                }
            }

            public void Execute(object parameter)
            {
                _execute((T)parameter);
            }

            public event EventHandler CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }
        }

        public class RelayCommand : ICommand
        {
            private Action<object> execute;
            private Func<object, bool> canExecute;

            public event EventHandler CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }

            public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
            {
                this.execute = execute;
                this.canExecute = canExecute;
            }

            public bool CanExecute(object parameter)
            {
                return this.canExecute == null || this.canExecute(parameter);
            }

            public void Execute(object parameter)
            {
                this.execute(parameter);
            }
        }
    }
}