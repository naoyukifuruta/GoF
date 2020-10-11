﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    using Framework;

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            UnderlinePen upen = new UnderlinePen('~');
            MessageBox mbox = new MessageBox('*');
            MessageBox sbox = new MessageBox('/');

            manager.Register("strong message", upen);
            manager.Register("warning box", mbox);
            manager.Register("slash box", sbox);

            Product p1 = manager.Create("strong message");
            p1.Use("Hello, world");
            Product p2 = manager.Create("warning box");
            p2.Use("Hello, world");
            Product p3 = manager.Create("slash box");
            p3.Use("Hello, world");
        }
    }

    public class MessageBox : Product
    {
        private char decochar;

        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }

        public void Use(string s)
        {
            int length = s.Length;
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
            Console.WriteLine($"{decochar} {s} {decochar}");
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Product CreateClone()
        {
            return (Product)this.Clone();
        }
    }

    public class UnderlinePen : Product
    {
        private char ulchar;

        public UnderlinePen(char ulchar)
        {
            this.ulchar = ulchar;
        }

        public void Use(string s)
        {
            int length = s.Length;

            Console.WriteLine($"\"{s}\"");
            Console.Write(" ");

            for (int i = 0; i < length; i++)
            {
                Console.Write(ulchar);
            }
            Console.WriteLine("");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Product CreateClone()
        {
            return (Product)this.Clone();
        }
    }
}

namespace Framework
{
    public interface Product : ICloneable
    {
        void Use(string s);
        Product CreateClone();
    }

    public class Manager
    {
        private Dictionary<string, Product> showcase = new Dictionary<string, Product>();

        public void Register(string name, Product proto)
        {
            showcase.Add(name, proto);
        }

        public Product Create(string protoname)
        {
            Product p = showcase[protoname];
            return p.CreateClone();
        }
    }
}