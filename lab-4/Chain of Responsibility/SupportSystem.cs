class SupportSystem
{
    static void Main(string[] args)
    {
        SupportHandler basicSupport = new BasicSupport();
        SupportHandler mediumSupport = new MediumSupport();
        SupportHandler advancedSupport = new AdvancedSupport();

        basicSupport.SetNextHandler(mediumSupport);
        mediumSupport.SetNextHandler(advancedSupport);

        // Симулюємо запит на рівень 2
        basicSupport.HandleRequest(2);
    }
}
