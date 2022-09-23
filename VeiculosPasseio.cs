class VeiculosPasseio:Veiculos
{
    public int quantidadePassageiros { get; set; }
    public VeiculosPasseio(string cor, string modelo, string placa, string ano, int quantidadePassageiros) : base(cor, modelo, placa, ano)
    {
        this.cor = cor;
        this.modelo = modelo;
        this.placa = placa;
        this.ano = ano;
        this.quantidadePassageiros = quantidadePassageiros;
    }

    public bool viagem(int Passageiros)
    {
        if (Passageiros <= quantidadePassageiros){
            return true;
        }
        else
        {
            return false;
        }
    }
}