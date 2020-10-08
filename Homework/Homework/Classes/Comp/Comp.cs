using Homework.Classes.Disks;
using Homework.Interfaces.Disks;
using Homework.Interfaces.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Classes.Comp
{
    class Comp
    {
        public List<Disk> Disks { get; private set; }
        public List<IPrintInformation> PrintDevices { get; private set; }

        public Comp(List<Disk> disks = null, List<IPrintInformation> printDevices = null)
        {
            if (disks == null)
                Disks = new List<Disk>();
            else
                Disks = disks;

            if (printDevices == null)
                PrintDevices = new List<IPrintInformation>();
            else
                PrintDevices = printDevices;
        }

        public void AddDevice(IPrintInformation device)
        {
            PrintDevices.Add(device);
        }

        public void AddDisk(Disk disk)
        {
            Disks.Add(disk);
        }

        public bool CheckDisk(string disk)
        {
            for (int i = 0; i < Disks.Count; i++)
            {
                if (disk.Equals(Disks[i].GetName() + $" {(char)(i + 65)}"))
                    return true;
            }
            return false;
        }

        public void InsertReject(string disk, bool status)
        {
            for (int i = 0; i < Disks.Count; i++)
            {
                if (disk.Equals(Disks[i].GetName() + $" {(char)(i + 65)}"))
                {
                    if (Disks[i] is IRemoveableDisk)
                    {
                        if (status)
                            ((IRemoveableDisk)Disks[i]).Insert();
                        else
                            ((IRemoveableDisk)Disks[i]).Reject();

                        return;
                    }
                }
            }
        }

        public void PrintInfo(string device, string text)
        {
            for (int i = 0; i < PrintDevices.Count; i++)
            {
                if (device.Equals(PrintDevices[i].GetName() + $" {(char)(i + 65)}"))
                {
                    PrintDevices[i].Print(text);
                }
            }
        }

        public string ReadInfo(string disk)
        {
            for (int i = 0; i < Disks.Count; i++)
            {
                if (disk.Equals(PrintDevices[i].GetName() + $" {(char)(i + 65)}"))
                {
                    return Disks[i].Read();
                }
            }
            return null;
        }

        public void ShowDisk()
        {
            for (int i = 0; i < Disks.Count; i++)
            {
                Console.WriteLine($"Disk: {Disks[i].GetName()} {(char)(i + 65)}");
            }
        }

        public void ShowPrintDevice()
        {
            for (int i = 0; i < PrintDevices.Count; i++)
            {
                Console.WriteLine($"Disk: {PrintDevices[i].GetName()} {(char)(i + 65)}");
            }
        }

        public void WriteInfo(string text, string disk)
        {

            for (int i = 0; i < Disks.Count; i++)
            {
                if (disk.Equals(Disks[i].GetName() + $" {(char)(i + 65)}"))
                {
                    Disks[i].Write(text);
                }
            }
        }
    }
}
