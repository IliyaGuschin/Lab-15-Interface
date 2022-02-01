using System;

namespace Lab_15_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface ISeries
    {
        void setStart(int x);
        void getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        public void getNext()
        {
            throw new NotImplementedException();
        }

        public void reset()
        {
            throw new NotImplementedException();
        }

        public void setStart(int x)
        {
            throw new NotImplementedException();
        }
    }
    class GeomProgression : ISeries
         
    {
        int pValue, pCurrentValue;

        public void getNext()
        {
            return p;
        }

        public void reset()
        {
            pValue=0;
        }

        public void setStart(int x)
        {
        pValue = x;
        }
    }
}



