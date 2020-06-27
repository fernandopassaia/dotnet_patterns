using System.Runtime.Serialization;

namespace Consumer.Console.Dto
{
    public class ItemOrcResult
    {
        public string ItoPk { get; set; } = "";
        public string ItoCodFabr { get; set; } = "";
        public string ItoDescrAplic { get; set; } = "";
        public string ItoValorUnit { get; set; } = "";
        public string ItoQtd { get; set; } = "";
        public string ItoValorTotal { get; set; } = "";
        public string ProCodFabr { get; set; } = "";
        public string ProNcm { get; set; } = "";
        public string ProDescr { get; set; } = "";
        public string ProAplic { get; set; } = "";
        public string ProEstoque { get; set; } = "";
        public string CliPk { get; set; } = "";
        public string CliNome { get; set; } = "";
        public string OrcPk { get; set; } = "";
        public string OrcValor { get; set; } = "";
        public string VendPk { get; set; } = "";
        public string PedCod { get; set; } = "";
        public string PedValorPago { get; set; } = "";
        public string PedCaixa { get; set; } = "";
        public string VendNome { get; set; } = "";

        protected ItemOrcResult() { }

        public ItemOrcResult(System.String ItoPk, System.String ItoCodFabr, System.String ItoDescrAplic, System.String ItoValorUnit, System.String ItoQtd, System.String ItoValorTotal,
            System.String ProCodFabr, System.String ProNcm, System.String ProDescr, System.String ProAplic, System.String ProEstoque, System.String CliPk, System.String CliNome,
            System.String OrcPk, System.String OrcValor, System.String VendPk, System.String PedCod, System.String PedValorPago, System.String PedCaixa, System.String VendNome)
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
