using System;
using System.Diagnostics;
using DP.UnitTest.Utility;
using DP.Domain.Samples.Singleton;
using Xunit;
using Xunit.Abstractions;
using System.Threading.Tasks;
using System.Threading;

namespace DP.UnitTest
{
    public class UtSingleton
    {
        private readonly ITestOutputHelper _output;

        private readonly string[] lastNames = new string[]{
            "李","林","陳","謝","施","曾"
        };
        private readonly string[] firstNames = new string[]{
            "先生","小姐"
        };

        private enum SingletonType
        {
            NonThreadSafe = 1,
            DoubleCheck,
            Eager,
            Lazy
        }


        public UtSingleton(ITestOutputHelper output)
        {
            this._output = output;
            System.Diagnostics.Trace.Listeners.Add(new XunitTraceListener(this._output));
        }

        private string getRandomName()
        {
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            int rndLastNameIndex = rnd.Next(0, lastNames.Length - 1);
            int rndFirstNameIndex = rnd.Next(0, firstNames.Length - 1);

            return string.Format("{0} {1}", lastNames[rndLastNameIndex], firstNames[rndFirstNameIndex]);
        }

        private int getRandomAmt()
        {
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(1, 5);
        }

        private void simulate(SingletonType singletonType)
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Run(() =>
                {
                    for (int j = 0; j < 30; j++)
                    {
                        // var amt = this.getRandomAmt(); //預購數
                        var amt = 2; //預購數

                        NumberProvider counter = null;

                        switch (singletonType)
                        {
                            case SingletonType.NonThreadSafe:
                                counter = NonThreadSafeSingleton.Instance;
                                break;
                            case SingletonType.DoubleCheck:
                                counter = DoubleCheckSingleton.Instance;
                                break;
                            case SingletonType.Eager:
                                counter = EagerSingleton.Instance;
                                break;
                            case SingletonType.Lazy:
                                counter = LazySingleton.Instance;
                                break;
                        }

                        string preorderNumbers = string.Empty; //預購序號集合
                        for (int x = 0; x < amt; x++)
                        {
                            var number = counter.GetNumber();
                            preorderNumbers += $"*{number}* ";
                        }

                        Trace.WriteLine($"({Thread.CurrentThread.ManagedThreadId}){this.getRandomName()}預購{amt}組: {preorderNumbers}");
                    }
                });
            }
        }

        [Fact]
        public void TestNonThreadSafeSingleton()
        {
            this.simulate(SingletonType.NonThreadSafe);
            Thread.Sleep(5000);
        }

        [Fact]
        public void TestDoubleCheckSingleton()
        {
            this.simulate(SingletonType.DoubleCheck);
            Thread.Sleep(5000);
        }

        [Fact]
        public void TestEagerSingleton()
        {
            this.simulate(SingletonType.Eager);
            Thread.Sleep(5000);
        }

        [Fact]
        public void TestLazySingleton()
        {
            this.simulate(SingletonType.Lazy);
            Thread.Sleep(5000);
        }

    }
}
