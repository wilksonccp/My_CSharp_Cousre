namespace ExercicioDeFixacao;

public class Interacoes
{
    internal string InteracaoInicial01()
    {
        return $"      SISTEMA DE CONTROLE BANCÁRIO\n" +
                "------------------------------------------\n" +
                "Bem vindo ao sistema de controle bancário\n" +
                "Insira o valor Correspondente a sua opção:\n" +
                "1 - Sobre o sistema\n" +
                "2 - Operações";
    }
    internal string InteracaoInicialErro()
    {
        return $"Por gentileza, insira apenas um dos valores:\n" +
                "1 - Sobre o sistema\n" +
                "2 - Operações\n";
    }
    internal string PrimeiroMenu()
    {
        return "O que gostaria de fazer agora?\n" +
                "1 - Sobre o sistema\n" +
                "2 - Operações\n";
    }
    internal string MenuDeOperacoes()
    {
        return "--------------------OPERAÇÕES---------------------\n"+
                "Insira o valor correspondente a operação desejada\n"+
                "1 - Cadastrar conta\n"+
                "2 - Fazer um depósito\n"+
                "3 - Fazer um saque\n";
    }
    internal string MenuDeOperacoesErro()
    {
        return      "Por gentileza, insira apenas um dos valores:\n"+
                    "1 - Cadastrar conta\n"+
                    "2 - Fazer um depósito\n"+
                    "3 - Fazer um saque\n";
    }
}
