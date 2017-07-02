using System;
using System.Collections.Generic;
using System.Text;
using SimpleInjector;
using AntShares.Core;

namespace AntShares
{
    public class Bindings
    {
        static Container Container_Var;
        static Object Container_Lock = new Object();
        public static Container Container
        {
            get
            {
                lock (Container_Lock)
                {
                    if (null == Container_Var)
                    {
                        Container_Var = GetInjectorContainer();
                    }
                }
                return Container_Var;
            }

            private set
            {
                Container_Var = value;
            }
        }

        private static Container GetInjectorContainer()
        {
            Container container = new Container();

            // Core
            container.Register<IAccountState, AccountState>();

            // optional, verify
            container.Verify();

            return container;
        }
    }
}
