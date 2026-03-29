# MKnet.Solution

Landing page corporativo para **MKnET**, empresa de soluciones digitales.

## Descripcion

Proyecto ASP.NET Core 9.0 con Razor Components que implementa un landing page moderno y responsivo. El sitio presenta los servicios, equipo, portafolio y preguntas frecuentes de la empresa.

## Tecnologias

- **.NET 9.0** - Framework principal
- **ASP.NET Core** - Servidor web
- **Razor Components** - Interactividad del lado del servidor
- **Bootstrap 5** - Framework CSS para diseño responsivo

## Estructura del Proyecto

```
MKnet.Solution/
├── MKnet.Landing.Strategy/          # Proyecto principal
│   ├── Components/                   # Componentes Razor
│   │   ├── Landing/                   # Secciones del landing
│   │   │   ├── Components/            # Componentes reutilizables
│   │   │   │   ├── Faq.razor
│   │   │   │   ├── Media.razor
│   │   │   │   └── Service.razor
│   │   │   │   ├── Member.razor
│   │   │   │   ├── About.razor
│   │   │   │   ├── Faqs.razor
│   │   │   │   ├── Footer.razor
│   │   │   │   ├── Header.razor
│   │   │   │   ├── Hero.razor
│   │   │   │   ├── LandingHead.razor
│   │   │   │   ├── LandingScripts.razor
│   │   │   │   ├── Members.razor
│   │   │   │   ├── Porfolio.razor
│   │   │   │   ├── Services.razor
│   │   │   │   └── Testimonials.razor
│   │   │   └── App.razor
│   │   ├── Layout/
│   │   │   └── MainLayout.razor
│   │   └── Pages/
│   │       ├── Home.razor
│   │       └── Error.razor
│   ├── Data/                          # Archivos JSON de contenido
│   │   ├── hero.json
│   │   ├── about.json
│   │   ├── services.json
│   │   ├── members.json
│   │   ├── faqs.json
│   │   ├── media.json
│   │   ├── footer.json
│   │   └── sections.json
│   ├── Domain/
│   │   ├── Models/
│   │   │   └── Models.cs              # DTOs del proyecto
│   │   └── Services/
│   │       └── JsonHelper.cs          # Utilitario para cargar JSON
│   └── wwwroot/
│       └── lib/bootstrap/             # Librerias CSS/JS
└── MKnet.Solution.sln                 # Archivo de solucion
```

## Secciones del Landing Page

1. **Hero** - Banner principal con titulo e imagen
2. **About** - Informacion sobre la empresa
3. **Services** - Lista de servicios ofrecidos
4. **Portfolio** - Proyectos y trabajos realizados
5. **Members** - Equipo de trabajo
6. **FAQs** - Preguntas frecuentes

## Contenido Dinamico

El contenido del sitio se carga desde archivos JSON en la carpeta `Data/`. Esto permite modificar el contenido sin necesidad de recompilar el proyecto.

### Modelos de Datos

- `HeroDTO` - Datos del banner principal
- `AboutDTO` - Informacion sobre la empresa
- `ServiceDTO` - Servicios ofrecidos
- `MemberDTO` - Miembros del equipo
- `FaqDTO` - Preguntas frecuentes
- `MediaDTO` - Elementos del portafolio
- `FooterDTO` - Datos del pie de pagina

## Requisitos

- .NET 9.0 SDK
- Navegador web moderno

## Ejecucion

```bash
cd MKnet.Landing.Strategy
dotnet run
```

El sitio estara disponible en `https://localhost:7000` (puerto puede variar).

## Compilacion

```bash
dotnet build -c Release
```

Los archivos compilados se generaran en `bin/Release/net9.0/`.

## Licencia

Privado - Todos los derechos reservados
