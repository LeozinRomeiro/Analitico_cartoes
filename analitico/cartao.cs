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

    public bool Aumentar(double valor)
    {
        if (valor < 0)
            return false;
        else
            this.limite += valor; return true;
    }

    public bool Diminuir(double valor)
    {
        if(valor<this.limite)
            return false;
        else
            this.limite -= valor; return true;
    }
}