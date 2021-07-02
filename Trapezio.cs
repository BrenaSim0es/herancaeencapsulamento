using System;

public class Trapezio : Figura
{
    private double _baseMaior;
    private double _baseMenor;
    private double _altura;

    public double BaseMaior

    {
        get
        {
            return this._baseMaior;
        }

        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Base Inválida");
            }
            else
            {
                this._baseMaior = value;
                this.AtualizarArea();
                this.AtualizarPerimetro();
            }
        }
    }
    public double BaseMenor

    {
        get
        {
            return this._baseMenor;
        }

        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Base Inválida");
            }
            else
            {
                this._baseMenor = value;
                this.AtualizarArea();
                this.AtualizarPerimetro();
            }
        }
    }
    public double Altura
    {
        get
        {
            return this._altura;
        }

        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Altura Inválida");
            }
            else
            {
                this._altura = value;
                this.AtualizarArea();
                this.AtualizarPerimetro();
            }
        }
    }

    public Trapezio(double altura, double baseMaior, double baseMenor)
    {
        this.BaseMaior = baseMaior;
        this.BaseMenor = baseMenor;
        this.Altura = altura;
    }

    private void AtualizarArea()
    {
        this._area = (this._baseMaior + this._baseMenor) * this._altura /2;
    }
    private void AtualizarPerimetro()
    {
        this._perimetro = this._baseMaior + this._baseMenor + 2 * this._altura ;
    }

}
