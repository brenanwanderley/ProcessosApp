<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ProcessosApp</title>
</head>
<body>

<h1>ProcessosApp</h1>

<p><strong>ProcessosApp</strong> é um aplicativo web simples desenvolvido utilizando <strong>C#</strong>, <strong>.NET 8.0</strong>, <strong>Entity Framework</strong>, e <strong>MVC</strong> do <strong>ASP.NET Core</strong>. O projeto é um <strong>CRUD</strong> (Create, Read, Update, Delete) que permite administrar processos (criar, listar, editar e remover) com uma interface simples. Ele utiliza uma base de dados <strong>SQLite</strong> (banco em arquivo) e também faz uso de uma <strong>API externa do IBGE</strong> para obter dados de estados e municípios.</p>

<h2>Funcionalidades</h2>
<ul>
    <li><strong>Cadastro de Processos:</strong> Crie novos processos e faça a edição dos processos existentes.</li>
    <li><strong>Listagem de Processos:</strong> Visualize todos os processos cadastrados.</li>
    <li><strong>Exclusão de Processos:</strong> Remova processos da base de dados.</li>
    <li><strong>Integração com a API do IBGE:</strong> A aplicação consulta a API externa para obter dados de estados e municípios, permitindo que o usuário selecione esses dados ao cadastrar ou editar um processo.</li>
    <li><strong>Banco SQLite:</strong> O banco de dados é gerido automaticamente pelo <strong>Entity Framework Core</strong> e é armazenado em um arquivo local.</li>
</ul>

<h2>Tecnologias Usadas</h2>
<ul>
    <li><strong>C#:</strong> Linguagem de programação principal do projeto.</li>
    <li><strong>.NET 8.0:</strong> Framework de desenvolvimento da Microsoft.</li>
    <li><strong>Entity Framework Core:</strong> ORM para manipulação de dados e integração com o banco de dados.</li>
    <li><strong>MVC (Model-View-Controller):</strong> Padrão de arquitetura utilizado para estruturar a aplicação.</li>
    <li><strong>SQLite:</strong> Banco de dados em arquivo utilizado para armazenar os dados localmente.</li>
    <li><strong>API do IBGE:</strong> Para obter dados de estados e municípios.</li>
    <li><strong>jQuery:</strong> Utilizado para manipulação do DOM e requisições assíncronas (AJAX).</li>
    <li><strong>Bootstrap:</strong> Framework CSS para estilizar a interface de usuário.</li>
</ul>

<h2>Como Rodar o Projeto</h2>

<h3>1. Clonar o Repositório</h3>
<p>Clone este repositório para uma pasta no seu ambiente local:</p>
<pre><code>git clone https://github.com/brenanwanderley/ProcessosApp.git</code></pre>

<h3>2. Construir o Projeto</h3>
<p>Acesse a pasta do projeto:</p>
<pre><code>cd ProcessosApp</code></pre>
<p>Em seguida, execute o comando abaixo para construir o projeto:</p>
<pre><code>dotnet build ProcessosApp.csproj</code></pre>

<h3>3. Executar o Projeto</h3>
<p>Após a construção do projeto, execute o seguinte comando para rodá-lo:</p>
<pre><code>dotnet run</code></pre>

<h3>4. Acessar o Aplicativo</h3>
<p>Quando o programa estiver em execução, você pode acessar a aplicação no seu navegador usando o seguinte link:</p>
<ul>
    <li><a href="http://localhost:5230">http://localhost:5230</a></li>
    <li><a href="http://localhost:5230/Processo">http://localhost:5230/Processo</a></li>
</ul>
<p>(Se a porta estiver configurada de maneira diferente no seu ambiente, substitua <strong>5230</strong> pela porta adequada.)</p>

<h3>5. Banco de Dados SQLite</h3>
<p>O banco de dados do projeto está configurado para utilizar o <strong>SQLite</strong> e já contém alguns dados de teste. Caso você tenha algum problema com o banco ou precise criar ou atualizar o banco, execute o seguinte comando:</p>
<pre><code>dotnet ef database update</code></pre>
<p>Este comando criará ou atualizará o banco de dados SQLite local, conforme as migrações configuradas.</p>

<h2>Testes</h2>
<p>Os testes do projeto foram realizados utilizando o terminal do <strong>Visual Studio Code</strong>. Para rodar o projeto, basta executar os comandos de build e run mencionados anteriormente.</p>

<h2>Contribuições</h2>
<p>Contribuições são bem-vindas! Sinta-se à vontade para abrir <strong>issues</strong> ou enviar <strong>pull requests</strong> para melhorar este projeto.</p>

<h2>Licença</h2>
<p>Este projeto está licenciado sob a licença MIT - veja o arquivo <a href="LICENSE">LICENSE</a> para mais detalhes.</p>

</body>
</html>
