using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa-Fundamentos", PrimeiroPrograma.Executar},
                {"Fundamentos sobre comentários de código-Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes-Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência de tipos-Fundamentos", Inferencia.Executar},
                {"Interpolação de dados-Fundamentos", Interpolacao.Executar},
                {"Notação Ponto-Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados do Console-Fundamentos", LendoDadosDoConsole.Executar},
                {"Formatando Número-Fundamentos", FormatandoNumero.Executar},
                {"Conversões de valores-Fundamentos",Conversoes.Executar},
                {"Operadores Aritmédicos-Fundamentos",OperadoresAritmeticos.Executar},
                {"Operadores Relacionais-Fundamentos",OperadoresRelacionais.Executar},
                {"Operadores Lógicos-Fundamentos",OperadoresLogicos.Executar},
                {"Operadores de Atribuição-Fundamentos",OperadoresAtribuicao.Executar},
            });

            central.SelecionarEExecutar();
            Console.WriteLine("Aperte qualquer tecla para finalizar a execução:");
            Console.ReadLine();
        }
    }
} 