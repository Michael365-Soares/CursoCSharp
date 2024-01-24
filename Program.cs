using System;
using System.Collections.Generic;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

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
                {"Usando continue-EstruturasDeControle",UsandoContinue.Executar },
                //Classes e Métodos 
                {"Membros-ClassesEMetodos",Membros.Executar},
                {"Construtores-ClassesEMetodos",Construtores.Executar},
                {"Métodos com retorno-ClassesEMetodos",MetodosComRetorno.Executar},
                {"Métodos estáticos-ClassesEMetodos",MetodosEstaticos.Executar},
                {"Atributos estáticos-ClassesEMetodos",AtributosEstaticos.Executar},
                {"Desafio Atributo-ClassesEMetodos",DesafioAtributo.Executar},
                {"Params -ClassesEMetodos",Params.Executar},
                {"Parâmetros nomeados-ClassesEMetodos",ParametrosNomeados.Executar},
                {"Métodos Getters and Setters-ClassesEMetodos",GetSet.Executar},
                {"Props-ClassesEMetodos",Props.Executar},
                {"ReadOnly-ClassesEMetodos",ReadOnly.Executar},
                {"Enum-ClassesEMetodos",ExemploEnum.Executar},
                {"Struct-ClassesEMetodos",ExemploStruct.Executar},
                {"StructVsClass-ClassesEMetodos",StructVsClass.Executar},
                {"ValorVsReferencia-ClassesEMetodos",ValorVsReferencia.Executar},
                {"Parâmtros por referência-ClassesEMetodos",ParametrosPorReferencia.Executar},
                {"Parâmetro com Valor Padrão-ClassesEMetodos",ParametroPadrao.Executar},
                //Coleções
                {"Estrutura de dados Array-Colecoes",Colecoes.Array.Executar },
                {"Estrutura de dados List-Colecoes",ColecoesList.Executar},
                {"Estruturas de dados ArrayList-Coleções",ColecoesArrayList.Executar}
        });

            central.SelecionarEExecutar();
            Console.WriteLine("Aperte qualquer tecla para finalizar a execução:");
            Console.ReadLine();
        }
    }
} 