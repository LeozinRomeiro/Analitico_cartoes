using System.Runtime.CompilerServices;

public class cartao
{
    public int numero;
    public int cvc;
    public string nome;
    public double limite=1000;

    public bool Creditar(double valor)
    {
        if (this.limite < valor)
            return false;
        else
            this.limite -= valor; return true;
    }
}