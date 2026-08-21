using System;
using System.Text;


namespace XulambsFoods {    
    public class Pizza {

        /// <summary>
        /// Lembre-se:
        // ENTENDER O PROBLEMA!!!
        //Regra 0 -- não entre em pânico
        //Regra 1 -- não viaje
        /// </summary>
        /// 
        #region atributos
        int _maxIngredientes;
        double _precoBase;
        int _quantIngredientes;
        double _valorPorAdicional;
        string _descricao;
        #endregion

        private void Init(int adicionais)
        {
            _descricao = "Pizza";
            _maxIngredientes = 8;
            _precoBase = 29d;
            AdicionarIngredientes(_quantIngredientes);
            _valorPorAdicional = 5d;
        }

        #region construtores
        public Pizza() {
            Init(0);
        }

        public Pizza(int adicionais)
        {
            Init(adicionais);
        }
        #endregion

        #region métodos privados
        private double ValorAdicionais() {
            return _quantIngredientes * _valorPorAdicional;
        }

        private void ModificarDescricao() {
            _descricao = $"Pizza com {_quantIngredientes} adicionais";
        }

        private bool PodeAdicionar(int quantos) {
            return (quantos >= 0 && 
                    quantos + _quantIngredientes <= _maxIngredientes) ;
        }
        #endregion

        #region métodos públicos
        public double CalcularValorFinal() {
            return _precoBase + ValorAdicionais();
        }

        public int AdicionarIngredientes(int quantos) {
            if (PodeAdicionar(quantos)) {
                _quantIngredientes = _quantIngredientes + quantos;
                ModificarDescricao();
            }
            return _quantIngredientes;
        }

        public string GerarCupom() {
            StringBuilder nota = new StringBuilder("XULAMBS PIZZA!!!\n");
            nota.AppendLine("====================");

            nota.Append("====================");
        }
        #endregion

    }
}