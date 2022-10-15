namespace ConsoleApp
{
    class FibonacciNumberSearcher
    {
        //F(0)=0, F(1)=1, F(n)=F(n-1)+F(n-2),
        public uint RecursionMethod(uint n)
        {
            return (n > 2) ? RecursionMethod(n - 1) + RecursionMethod(n - 2) : 1;
        }
        public uint CycleMethod(uint n)
        {            
            uint currentEl = 1;
            if (n > 2)
            {
                uint lastEl = 1;
                uint preLastEl = 1;
                for (uint i = 3; i <= n; i++)
                {
                    currentEl = preLastEl + lastEl;
                    preLastEl = lastEl;
                    lastEl = currentEl;                    
                }
            }
            return currentEl;
        }
    }
}
