
namespace Publisher.Console.Dto
{
    public class ItemOrcResult
    {
        public int ItoPk { get; set; }
        public string ItoCodFabr { get; set; }
        public string ItoDescrAplic { get; set; }
        public decimal ItoValorUnit { get; set; }
        public decimal ItoQtd { get; set; }
        public decimal ItoValorTotal { get; set; }
        public string ProCodFabr { get; set; }
        public string ProNcm { get; set; }
        public string ProDescr { get; set; }
        public string ProAplic { get; set; }
        public decimal ProEstoque { get; set; }
        public int CliPk { get; set; }
        public string CliNome { get; set; }
        public int OrcPk { get; set; }
        public decimal OrcValor { get; set; }
        public int VendPk { get; set; }
        public int PedCod { get; set; }
        public decimal PedValorPago { get; set; }
        public string PedCaixa { get; set; }
        public string VendNome { get; set; }

        protected ItemOrcResult() { }

        public ItemOrcResult(System.Int32 ItoPk, System.String ItoCodFabr, System.String ItoDescrAplic, System.Decimal ItoValorUnit, System.Decimal ItoQtd, System.Decimal ItoValorTotal,
            System.String ProCodFabr, System.String ProNcm, System.String ProDescr, System.String ProAplic, System.Decimal ProEstoque, System.Int32 CliPk, System.String CliNome, 
            System.Int32 OrcPk, System.Decimal OrcValor, System.Int32 VendPk, System.Int32 PedCod, System.Decimal PedValorPago, System.String PedCaixa, System.String VendNome)
        {
            this.ItoPk = ItoPk;
            this.ItoCodFabr = ItoCodFabr;
            this.ItoDescrAplic = ItoDescrAplic;
            this.ItoValorUnit = ItoValorUnit;
            this.ItoQtd = ItoQtd;
            this.ItoValorTotal = ItoValorTotal;
            this.ProCodFabr = ProCodFabr;
            this.ProNcm = ProNcm;
            this.ProDescr = ProDescr;
            this.ProAplic = ProAplic;
            this.ProEstoque = ProEstoque;
            this.CliPk = CliPk;
            this.CliNome = CliNome;
            this.OrcPk = OrcPk;
            this.OrcValor = OrcValor;
            this.VendPk = VendPk;
            this.PedCod = PedCod;
            this.PedValorPago = PedValorPago;
            this.PedCaixa = PedCaixa;
            this.VendNome = VendNome;
        }
    }
}
