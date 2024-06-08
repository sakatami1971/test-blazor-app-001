using CsvHelper.Configuration.Attributes;

namespace Data
{
    public class TestCsv
    {
        [Name("テスト列１")]
        public string TestClm1 { get; set; }
 
        [Name("テスト列２")]
        public string TestClm2 { get; set; }
 
        [Name("テスト列３")]
        public string TestClm3 { get; set; }
    }

    public class HighwayCsvFormatElement
    {
        public int? CarNo { get; set; }
        public string? ETCNo { get; set; }
        public string? StartDate { get; set; }
        public string? StartTime { get; set; }
        public string? EndDate { get; set; }
        public string? EndTime { get; set; }
        public string? StartICName { get; set; }
        public string? EndICName { get; set; }
        public int? Payment { get; set; }

    }

    public class FerryCsvFormatElement
    {
        public int? RowNo { get; set; }
        public string? BoardingDate { get; set; }
        public string? SeaRroute { get; set; }
        public string? BoardingFlight { get; set; }
        public string? CarNo { get; set; }
        public int? CarLength { get; set; }
        public int? ListPriceFreight { get; set; }
        public int? InvoiceFreight { get; set; }
        public int? BillAdjustmentFee { get; set; }
        public int? BillAmountTotal { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
    }
    public class DriverMasterElement{
        public string? No{ get; set; }
        public string? Name{ get; set; }
        public int? Commission{ get; set; }
        public int? BasicOperatingDays{ get; set; }
        public int? BasicHalfDayUnitPrice{ get; set; }
        public int? BasicDailyUnitPrice{ get; set; }
    }
    public class DriveInfoElement{
        public int No{ get; set; }
        public int Select{ get; set; }
        public string DateOfBoarding{ get; set; }
        public string CarNo{ get; set; }
        public string Exception{ get; set; }
        public int Distance{ get; set; }
        public int NetSalesTotal{ get; set; }
        public int Commission{ get; set; }
        public int ConsolidationAllowance{ get; set; }
        public int CargoHandlingAllowance{ get; set; }
        public int AssistantAllowance{ get; set; }
        public int EmptyCarAllowance{ get; set; }
        public int WorkAllowance{ get; set; }
        public int AdvancePayment{ get; set; }
        public int HighwayPayment{ get; set; }
    }
    public class FerryElement{
        public string Name{ get; set; }
        public string DateOfBoarding{ get; set; }
        public string ActualVehicle{ get; set; }
        public int Flight{ get; set; }
        public string RouteName{ get; set; }
        public string TimeOfBoarding{ get; set; }
        public int Amount{ get; set; }
        public int ElectricBill{ get; set; }
        public int PassengerFee{ get; set; }
    }
    public class AdvancePaymentElement{
        public int? No{ get; set; }
        public string? DateOfAdvance{ get; set; }
        public string? Name{ get; set; }
        public int? Amount{ get; set; }
    }
    public class HighwayPaymentElement{
        public int? No{ get; set; }
        public string? DateOfHighway{ get; set; }
        public string? StartSection{ get; set; }
        public string? EndSection{ get; set; }
        public int? Amount{ get; set; }
    }
    public class AmountElement{
        public string? Name{ get; set; }
        public int? Amount{ get; set; }
    }
    public class CarMasterElement{
        public string? No{ get; set; }
        public string? Name{ get; set; }
        public int? Length{ get; set; }
    }
    public class TotalAmountElement{
        public string? Name{ get; set; }
        public int? Amount{ get; set; }
    }

    public class FerryMasterElement{
        public string? No{ get; set; }
        public string? Name{ get; set; }
    }    

}