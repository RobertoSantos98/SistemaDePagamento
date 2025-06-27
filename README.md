# 💳 Sistema de Pagamento

Projeto criado com fins **educacionais e de estudo** para aplicar e testar os conceitos de **Polimorfismo**, **Herança**, **Interfaces**, **Classes Abstratas** e boas práticas no desenvolvimento de APIs RESTful usando ASP.NET Core.

---

## 🚀 Tecnologias

* ✅ ASP.NET Core 6
* ✅ C#
* ✅ POO (Herança, Polimorfismo, Interfaces, Abstração)
* ✅ Enum + Serialização JSON
* ✅ Swagger (OpenAPI)
* ✅ Boas práticas REST

---

## 📁 Estrutura de Pastas

```
SistemaDePagamento/
├── Controllers/           # Endpoints da API
├── Application/Service/   # Camada de aplicação (lógica de negócio)
├── Domain/
│   ├── DTOs/              # Objetos de transferência de dados
│   ├── Enums/             # Enums como TipoDePagamento
│   ├── Interfaces/        # Contratos para regras de negócio
│   ├── Models/            # Modelos principais e ResponseModel
```

---

## 📌 Funcionalidades

* Processar pagamento com **Cartão**
* Processar pagamento com **Pix**
* Processar pagamento com **Boleto**
* Gerar uma resposta padronizada para cada operação

---

## 📬 Rotas da API

| Método | Rota                        | Descrição                               |
| ------ | --------------------------- | --------------------------------------- |
| POST   | `/api/v1/pagamentos`        | Processa um pagamento genérico via enum |
| POST   | `/api/v1/pagamentos/cartao` | Processa pagamento com Cartão           |
| POST   | `/api/v1/pagamentos/pix`    | Processa pagamento com Pix              |
| POST   | `/api/v1/pagamentos/boleto` | Processa pagamento com Boleto           |

---

## 📄 Exemplo de JSON para requisição

```json
{
  "valor": 150.00,
  "tipoDePagamento": "Boleto"
}
```

> ⚠️ O campo `tipoDePagamento` deve ser um dos seguintes valores válidos:
>
> * "Cartao"
> * "Pix"
> * "Boleto"

---

## ⚙️ Como rodar o projeto localmente

1. Clone o repositório:

   ```bash
   git clone https://github.com/RobertoSantos98/SistemaDePagamento.git
   cd SistemaDePagamento
   ```

2. Restaure os pacotes:

   ```bash
   dotnet restore
   ```

3. Execute a aplicação:

   ```bash
   dotnet run
   ```

4. Acesse a API no navegador via:

   ```
   https://localhost:5001/swagger
   ```

---

## ✅ Ajuste importante no Program.cs

Para que o enum funcione corretamente com valores como "Boleto", adicione isto no `Program.cs`:

```csharp
builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
```

---

## 📦 Exemplo de Response

```json
{
  "success": true,
  "mensagem": "Pagamento processado com sucesso",
  "tipo": "Boleto",
  "valor": 150.0
}
```

---

## 👨‍💻 Autor

Desenvolvido por **Roberto Felipe Nogueira Raphael dos Santos**

[LinkedIn](https://www.linkedin.com/in/robertosantos98) | [GitHub](https://github.com/RobertoSantos98)

---

