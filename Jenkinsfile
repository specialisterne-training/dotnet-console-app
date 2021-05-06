pipeline {
    agent any

    stages {
        stage('Byg Software') {
            steps {
                // Hente kode fra GitHub repository
                git branch: 'main', url: 'https://github.com/specialisterne-training/dotnet-console-app.git'

                // To run Maven on a Windows agent, use
                sh "dotnet run --project src/DotnetConsoleApp"
            }

            post {
                // If Maven was able to run the tests, even if some of the test
                // failed, record the test results and archive the jar file.
                success {
                    sh "dotnet test test/DotnetConsoleApp.Tests --filter Category=SmokeTest --logger html"
                }
            }
        }
    }
}
