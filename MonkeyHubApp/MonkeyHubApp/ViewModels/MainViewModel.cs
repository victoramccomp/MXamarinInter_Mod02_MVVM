using System.Threading.Tasks;
using System.ComponentModel;

namespace MonkeyHubApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Descricao { get; set; }

        public MainViewModel()
        {
            Descricao = "Olá Mundo! Eu estou aqui!";

            Task.Delay(3000).ContinueWith(t =>
            {
                Descricao = "Meu texto mudou!";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Descricao)));
            });
        }
    }
}
