using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PuntoaPunto.model
{
    partial class Distancia : ObservableObject
    {
        [ObservableProperty]
        private double p1;

        [ObservableProperty]
        private double p2;

        [ObservableProperty]
        private double p3;

        [ObservableProperty]
        private double p4;

        [ObservableProperty]
        private string total;

        [RelayCommand]
        public void CalcularDistancia()
        {
            double calculo = Math.Sqrt(Math.Pow(p2 - p1, 2) + Math.Pow(p4 - p3, 2));
            Total = $"La distancia es: {calculo:F2}";
        }
    }
}
