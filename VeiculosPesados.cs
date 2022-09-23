class VeiculosPesados:Veiculos
{
    public double capacidadeCarga {get;set;}
    public VeiculosPesados(string cor, string modelo, string placa, string ano, double capacidadeCarga ):base(cor, modelo, placa, ano)
    {
        this.cor = cor;
        this.modelo = modelo;
        this.placa = placa;
        this.ano = ano;
        this.capacidadeCarga = capacidadeCarga;

    }
    public bool levantarCarga(double cargaAlevantar)
    {
        if(this.capacidadeCarga>= cargaAlevantar)
        {
            return true;
        }
        else{
            return false;
        }
    }
}
  