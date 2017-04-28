using System.Threading.Tasks;
using System.ComponentModel;

namespace MonkeyHubApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set
            {
                _descricao = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Descricao)));
            }
        }

        public MainViewModel()
        {
            Descricao = "Olá Mundo! Eu estou aqui!";

            Task.Delay(3000).ContinueWith(t =>
            {
                Descricao = "Meu texto mudou!";
            });
        }
    }
}
