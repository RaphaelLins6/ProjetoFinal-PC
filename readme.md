# 📋 Kanban To Do API

Este projeto é uma aplicação ASP.NET Core Web API com um front-end HTML/CSS/JS simples para gerenciamento de tarefas no estilo **Kanban**.

---

## 🖼️ Visão Geral Gráfica

```
┌───────────────────────────────┐
│        Navegador Web          │
│  (index.html em wwwroot)      │
│                               │
│  ┌───────────────┐            │
│  │   Kanban      │            │
│  │ ┌───────────┐ │            │
│  │ │  A Fazer  │ │            │
│  │ └───────────┘ │            │
│  │ ┌───────────┐ │            │
│  │ │ Em Prog.  │ │            │
│  │ └───────────┘ │            │
│  │ ┌───────────┐ │            │
│  │ │Concluído  │ │            │
│  │ └───────────┘ │            │
│  └───────────────┘            │
│         ▲   ▲   ▲             │
│         │   │   │             │
│   fetch/REST API requests     │
└─────────┼─────────────────────┘
          │
          ▼
┌───────────────────────────────┐
│        ASP.NET Core API       │
│    (Controllers/C# Models)    │
│  - GET /api/tarefas           │
│  - POST /api/tarefas          │
│  - PUT /api/tarefas/{id}      │
│  - PUT /api/tarefas/{id}/mover│
│  - DELETE /api/tarefas/{id}   │
└───────────────────────────────┘
```

---

## 🚀 Como funciona

- O usuário acessa `index.html` (interface Kanban) via navegador.
- O front-end faz requisições REST para a API ASP.NET Core.
- As tarefas são exibidas e manipuladas em três colunas: **A Fazer**, **Em Progresso** e **Concluído**.
- Cada tarefa pode ser movida entre colunas, marcada como concluída (círculo verde) ou excluída (botão vermelho).

---

## 🛠️ Principais Tecnologias

- **Back-end:** ASP.NET Core Web API
- **Front-end:** HTML, CSS, JavaScript (fetch API)
- **Swagger:** Documentação automática da API

---

## 📂 Estrutura de Pastas

```
ProjetoFinal/
└── ToDoApi/
    ├── Controllers/
    │   └── TarefasController.cs
    ├── Models/
    │   └── Tarefa.cs
    ├── wwwroot/
    │   └── index.html
    ├── Program.cs
    └── ...
```

---

## 💡 Como usar

1. Execute a API com `dotnet run`.
2. Acesse [http://localhost:5083/index.html](http://localhost:5083/index.html) no navegador.
3. Gerencie suas tarefas visualmente no Kanban!

---

## ✨ Exemplo Visual

![Exemplo Kanban](https://user-images.githubusercontent.com/25181517/236909406-7b2e2e6b-2e2b-4e8c-8e2e-5e8e2e2e2e2e.png)

---

> Projeto acadêmico para controle visual de tarefas com API REST e front-end leve.