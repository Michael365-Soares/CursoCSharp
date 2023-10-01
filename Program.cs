using System;
using System.Collections.Generic;
using CursoCSharp.EstruturasDeControle;
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
                {"Operadores Unários-Fundamentos",OperadoresUnarios.Executar},
                {"Operador Ternário-Fundamentos",OperadorTernario.Executar},
                //Capítulo de Estruturas de Controle
                {"Estrutura If-EstruturasDeControle",EstruturaIf.Executar},
                {"Estrutura If/Else-EstruturasDeControle",EstruturaIfElse.Executar},
                {"Estrutura If/ElseIf-EstruturasDeControle",EstruturaIfElseIf.Executar},
                {"Estrutura Switch-EstruturasDeControle",EstruturaSwitch.Executar},
                {"Estrutura While-EstruturasDeControle",EstruturaWhile.Executar },
                {"Estrutura DoWhile-EstruturasDeControle",EstruturaDoWhile.Executar },
                {"Estrutura For-EstruturasDeControle",EstruturaFor.Executar },
                {"Estrutura Foreach-EstruturasDeControle",EstruturaForeach.Executar },
                {"Usando break-EstruturasDeControle",UsandoBreak.Executar },
                {"Usando continue-EstruturasDeControle",UsandoContinue.Executar }
            });

            central.SelecionarEExecutar();
            Console.WriteLine("Aperte qualquer tecla para finalizar a execução:");
            Console.ReadLine();
        }
    }
} 