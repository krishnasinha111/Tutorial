using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    public interface ITestInterface
    {
        void TestMethod();
    }

    public sealed class SingletonTestClass : ITestInterface
    {
        public static readonly SingletonTestClass instance = new SingletonTestClass();

        private SingletonTestClass() { }

        public static SingletonTestClass GetSingletonTestClass()
        {
            return instance;
        }
        public void TestMethod()
        {
            throw new NotImplementedException();
        }
    }

    class TestClass : ITestInterface
    {
        public int serial;

        public void TestMethodAcceptsSingletonObject(SingletonTestClass singletonSampleClass)
        {

        }

        public void TestMethod()
        {
            throw new NotImplementedException();
        }
    }



    public static class StaticTestClass : ITestInterface
    {
        public StaticTestClass()
        {

        }

        void ITestInterface.TestMethod()
        {
            throw new NotImplementedException();
        }
    }
}
