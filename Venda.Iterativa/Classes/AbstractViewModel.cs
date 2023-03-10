using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venda.Iterativa.Interfaces;

namespace Venda.Iterativa.Classes
{
    internal abstract class AbstractViewModel : AbstractNotifyPropertyChange, ISubject
    {
        #region variaveis privadas

        private readonly List<IObserver> _observers = new List<IObserver>();
        private string _titulo = string.Empty;

        #endregion variaveis privadas

        #region propriedades

        public string Titulo 
        { 
            get => _titulo;
            set => SetField(ref _titulo, value);
        }

        #endregion propriedades

        #region construtores

        protected AbstractViewModel(string titulo)
        {
            Titulo = titulo;
        }

        #endregion construtores

        public void Add(IObserver observer)
            => _observers.Add(observer);

        public void Remove(IObserver observer)
            => _observers.Remove(observer);

        public void Notify()
            => _observers.ForEach(x => { x.Update(this); });

    }
}