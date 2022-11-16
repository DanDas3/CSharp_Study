using BogusFrame.Classes;

namespace BogusFrame.Regras
{
    public class Manutencao
    {
        public bool Test1(ClassB obj)
        {
            if (string.IsNullOrWhiteSpace(obj.PropE))
            {
                throw new Exception("Propriedade E vazia.");
            }
            return obj.PropF.Count > 0;
        }
    }
}
