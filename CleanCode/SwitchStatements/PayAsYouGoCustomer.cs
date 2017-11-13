namespace CleanCode.SwitchStatements
{
    public class PayAsYouGoCustomer : Customer
    {

        public override MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage)
        {
            var monthlyStatement = new MonthlyStatement
            {
                CallCost = 0.12f * monthlyUsage.CallMinutes,
                SmsCost = 0.12f * monthlyUsage.SmsCount
            };
            monthlyStatement.TotalCost = monthlyStatement.CallCost + monthlyStatement.SmsCost;

            return monthlyStatement;
        }
    }
}