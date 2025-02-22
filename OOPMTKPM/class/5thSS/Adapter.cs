using System;

namespace Adapter
{
    // Interface Definitions
    interface LightningPhone
    {
        void recharge();
        void useLightning();
    }

    interface MicroUsbPhone
    {
        void recharge();
        void useMicroUsb();
    }

    // iPhone using Lightning
    class Iphone : LightningPhone
    {
        private bool connector;

        public void useLightning()
        {
            connector = true;
            Console.WriteLine("Lightning connected");
        }

        public void recharge()
        {
            if (connector)
            {
                Console.WriteLine("Recharge started");
                Console.WriteLine("Recharge finished");
            }
            else
            {
                Console.WriteLine("Connect Lightning first");
            }
        }
    }

    // Android using MicroUSB
    class Android : MicroUsbPhone
    {
        private bool connector;

        public void useMicroUsb()
        {
            connector = true;
            Console.WriteLine("MicroUSB connected");
        }

        public void recharge()
        {
            if (connector)
            {
                Console.WriteLine("Recharge started");
                Console.WriteLine("Recharge finished");
            }
            else
            {
                Console.WriteLine("Connect MicroUSB first");
            }
        }
    }

    // Adapter: Convert LightningPhone to MicroUsbPhone
    class LightningToMicroUsbAdapter : MicroUsbPhone
    {
        private readonly LightningPhone lightningPhone;

        public LightningToMicroUsbAdapter(LightningPhone lightningPhone)
        {
            this.lightningPhone = lightningPhone;
        }

        public void useMicroUsb()
        {
            Console.WriteLine("MicroUSB connected");
            lightningPhone.useLightning();
        }

        public void recharge()
        {
            lightningPhone.recharge();
        }
    }

    
}
