# Desafio de Laboratório: Configurando uma Instância de Banco de Dados na Azure

O objetivo deste repositório é documentar a criação de uma instância de banco de dados através da plataforma Microsoft Azure.

## Criação

No portal da Microsoft Azure, foi escolhida a opção de criar uma instância gerenciada de SQL dentro da aba Azure SQL, utilizando do plano Azure for Students como método de inscrição.

![alt text](https://github.com/KenzoWVY/resumo-do-lab-azure-db/blob/main/images/deployed.PNG "Deployed")  

## Configuração

Por ser uma instância de testes temporária foram escolhidas as opções mais básicas de computação: 4vCores e 32GB de armazenamento, e como autenticação, um login SQL. Nas opções de rede, foi selecionada a opção de permitir o acesso da instância pela internet.

## Conexão

Dentro das regras de segurança da instância, foi adicionado o meu endereço IP como permitido de utilizar a porta padrão do SQL Server. Uma API foi criada utilizando do .NET Entity Framework Core, e um POST http foi enviado para um banco de dados criado na instância:


![alt text](https://github.com/KenzoWVY/resumo-do-lab-azure-db/blob/main/images/post.PNG "Interface swagger")  

Na *overview* da instância, foi possível observar uma pequena parte do armazenamento sendo utilizado, e fazendo uma consulta através do comando "SELECT" no Microsoft SQL Management Studio, foi confirmado que os dados realmente foram criados.

![alt text](https://github.com/KenzoWVY/resumo-do-lab-azure-db/blob/main/images/storage.PNG "Armazenamento")
![alt text](https://github.com/KenzoWVY/resumo-do-lab-azure-db/blob/main/images/select.PNG "Select")  

## Conclusão

Através da tarefa realizada, foi possível entender melhor o funcionamento do Microsoft Azure e de suas instâncias de bancos de dados, bem como configurar um programa em Entity Framework para se conectar com servidores. Com esses conhecimentos, possuo uma melhor visão sobre bancos de dados, computação em nuvem e a plataforma da Microsoft em geral.

