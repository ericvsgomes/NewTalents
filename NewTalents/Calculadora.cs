namespace NewTalents
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private DateTime Data;

        public Calculadora(DateTime data)
        {
            ListaHistorico = new List<string>();
            Data = data;
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            ListaHistorico.Insert(0, "Res: " + resultado + " - data: " + Data);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            ListaHistorico.Insert(0, "Res: " + resultado + " - data: " + Data);
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            ListaHistorico.Insert(0, "Res: " + resultado + " - data: " + Data);
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            ListaHistorico.Insert(0, "Res: " + resultado + " - data: " + Data);
            return resultado;
        }

        public List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}