namespace Jargar.Portfolio.Data;

public class JobExperience
{
    public required string Title { get; set; }
    public required string Company { get; set; }
    public required string Location { get; set; }
    public required string Period { get; set; }
    public required string Description { get; set; }
    public required List<string> Achievements { get; set; }

    public JobExperience()
    {
        Achievements = [];
    }
}

public static class ResumeData
{
    public static List<JobExperience> GetJobExperiences()
    {
        return
    [
        new() {
            Title = "Senior Software Engineer",
            Company = "Blackfinch",
            Location = "Gloucester",
            Period = "2024 - Ongoing",
            Description = "Provided technical leadership and hands-on development expertise within an agile team. Collaborated across teams to deliver robust, secure and scalable solutions for the Nest's application loans and ventures with microservices pattern.",
            Achievements =
            [
                "First developer on greenfield project for pension assisted architecht in architecting and designing the new application",
                "Mentoring and coaching junior developers, enforcing best practices in software development",
                "Ensuring high quality code through code reviews by implementing an always refactor with new pull requests as well as helping implement test-driven development",
                "Created pipelines for deployment of Apps and Azure infrastructur"
            ]
        },
        new() {
            Title = "Senior Software Engineer",
            Company = "Pina Vida",
            Location = "Edinburgh",
            Period = "2023 - 2023",
            Description = "Led migration of Referrals, an integrated workflow system for diamond analysis hardware, from .NET Core 3.1 to .NET 7 while certifying high availability and optimised performance during migration process. Developed Python scripts to execute complex algorithms, contributing to system's analytical capabilities. Partnered closely with cross-functional teams using Scrum and Three Amigos-style planned sessions to align Referrals with diverse needs of stakeholders.",
            Achievements =
            [
                "Employed event-driven programming using Rx.NET to boost real-time data processing and improve system responsiveness.",
                "Integrated various embedded hardware components, such as diamond analysis hardware and NFC card readers, into Referral system, broadening capabilities.",
                "Implemented critical features for system, including microservices, using C#, WPF, Angular, CosmosDB, and Azure DevOps Pipelines, enhancing system functionality.",
                "Led comprehensive implementation of four out of eight distinct microservices."
            ]
        },
        new() {
            Title = "Senior Software Engineer",
            Company = "Dyneval",
            Location = "Edinburgh",
            Period = "2021 - 2023",
            Description = "Orchestrate end-to-end design and execution of technical solutions aligning seamlessly with customer specifications, leading to enhanced customer satisfaction and retention. Collaborate closely with CEO and CTO, fostering efficient communication channels to facilitate smooth progression of technical projects, ensuring alignment with organisational goals and objectives. Streamline development process by implementing automated pipelines within Azure DevOps, enabling efficient code testing and benchmarking. Mentor and guide junior developers, nurturing professional growth and increasing team cohesion. Craft top-notch training materials and deliver training sessions to users, empowering clients in deploying/using products effectively. Guided and mentored junior developers, fostering growth and instilling best practices in software development.",
            Achievements =
            [
                "Employed event-driven programming using Rx.NET to boost real-time data processing and improve system responsiveness.",
                "Strengthened development unit and facilitated project scalability by recruiting, interviewing, and onboarding three junior developers, two mid-level developers and software manager.",
                "Achieved 80% performance boost by reducing hot path processing time from 5 minutes to just 1 minute, and maximising user experience and operational efficiency.",
                "Augmented revenue streams by heading transformation of product from proof of concept to full-scale production launch, resulting in widespread adoption by over 100+ customers.",
                "Guaranteed full compliance with data protection regulations, fortified data security measures, and mitigated potential legal risks associated with product by employing stringent GDPR software standards.",
                "Spearheaded development of a comprehensive solution, combining a WPF desktop app (C# .NET, XAML), React website, mobile app (Xamarin.Forms), and an Asp.net Core API on AWS. Implemented complex mathematical algorithms for fertility sample quality assessment, enhancing accuracy and efficiency."
            ]
        },
        new() {
            Title = "Mobile Engineer",
            Company = "McDermott Group",
            Location = "Glasgow",
            Period = "2019 - 2021",
            Description = "Directed Xamarin.Forms mobile developer within dynamic team of 15 developers, cultivating collaboration and synergy in SCRUM environment managed through Azure DevOps and MS Teams. Connected closely with cross-functional teams including frontend, mobile, data, and design, assuring seamless coordination across various projects. Provided guidance and leadership to mobile development team, steering efforts towards successful and timely delivery of projects. Facilitated informed decision-making and refined project execution by actively engaging in sprint reviews and meetings, contributing valuable project updates/insights.",
            Achievements =
            [
                "Played pivotal role in development and architecture of mobile module for Chameleon Vision, project with central focus on both Machine Learning and IoT innovation",
                "Automated deployment cycle by creating DevOps pipelines, amplifying efficiency/reducing manual intervention.",
                "Elevated workflow and advanced project progression by overseeing mobile team backlog management and task prioritisation, confirming optimal utilisation of resources."
            ]
        },
        new() {
            Title = "Junior Software Developer",
            Company = "Consulence",
            Location = "Lund, Sweden",
            Period = "2015 – 2019",
            Description = "Tackled diverse array of projects in C# as outsourced consultant, ranging from medical technology desktop development using WPF fin-tech development with Angular and e-commerce with Xamarin.Forms",
            Achievements = []
        }
    ];
    }
}
