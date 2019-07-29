using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria {
    class Conta {

        public int Numero { get; private set; }
        public string Titular { get; private set; }

        public double Saldo { get; private set; }
        public Conta(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }
        public Conta(int numero, string titular, double saldo) : this(numero, titular) {
            Depositar(saldo);
        }

        public double Sacar(double saque) {
            return Saldo -= saque + 5;
        }
        public double Depositar(double deposito) {
            return Saldo += deposito;
        }

        public override string ToString() {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo " + Saldo;
        }
    }
}
