namespace Alura.LeilaoOnline.Tests
{

    #region Testes promovem rápido feedback
    /*
        Forma dos 3A para escrever  teste

        O padrão Arrange-Act-Assert determina que dividamos o teste em 3 seções: uma para definir as condições de entrada (Arrange),
        outra para indicar qual método está sob teste (Act) e
        outra para verificar as expectativas de saída (Assert).

        1ª Arrange
        Nesta etapa nós configuramos tudo o que é necessário para que o nosso teste possa rodar, inicializamos variáveis, criamos alguns test doubles como Mocks ou Spies dentre outras coisas.
        
        2ª Act
        Esta etapa é onde rodamos de fato o nosso teste. Chamamos alguma função ou método que queremos por a prova.
        
        3ª Assert
        Esta etapa é onde faremos nosso assert. É onde verificamos se a operação realizada na etapa anterior (Act) surtiu o resultado esperado. Assim sabemos se o teste passa ou falha.
     */

    #endregion

    #region Ciclo de TDD

    /*
       ## Test Driven Devolopment : Desenvolvimento orientado a testes 
            ** (Teste ANTES do código de produção) 
     
        1º - Teste
            - Primeiro escreva o cenario de Teste
            - O teste irá falhar

        2º - Correção
            - Implemente a correção
            - O teste irá ficar verde

        3º - Refatoração
            - Refatore o codigo para uma forma mais elegante
     */

    #endregion

    #region Testes Documentam Comportamentos do Sistema
    /*
        -Qualquer comportamento deve ser ttraduzido em testes, inclusive as exceçoes
            Ex: Assert.Throws<T>
     */
    #endregion

    #region ReeDesign
    /*
        Podemos utilizar os testes para reescrever os desgin das classes

     */
    #endregion
}
