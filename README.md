## Introduction

the aim of this exercise is 
 - to use Mocks, and/or Fakes 
 - discuss the pro and cons 
 - dig into deeper test cases where behavior is tricky

Start by completing this file: Tests/ServiceLayerTests/StartWith_SomeUseCaseTest.cs

## How (and why and when) to avoid mocks

it's all about verifying that behaviour is truly the same between Stubs (fake or mocks) and production or adapters

### libraries that I used
 - Monads and functional extensions:
https://github.com/louthy/language-ext#optional-and-alternative-value-monads

which is a bit like https://arrow-kt.io/learn/typed-errors/nullable-and-option/

 - Fluent assertions 
 - Mocks
   https://github.com/moq/moq


### Langage c-sharp
https://dotnet.microsoft.com/en-us/download/dotnet

install on Mac https://formulae.brew.sh/cask/dotnet

### using Nunit3 on netCore 6

TODO: move to .Net7

# Reference links

- [GitLab CI Documentation](https://docs.gitlab.com/ee/ci/)
- [.NET Hello World tutorial](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/)

If you're new to .NET you'll want to check out the tutorial, but if you're
already a seasoned developer considering building your own .NET app with GitLab,
this should all look very familiar.

## What's contained in this project

The root of the repository contains the out of the `dotnet new console` command,
which generates a new console application that just prints out "Hello, World."
It's a simple example, but great for demonstrating how easy GitLab CI is to
use with .NET. Check out the `Program.cs` and `dotnetcore.csproj` files to
see how these work.

In addition to the .NET Core content, there is a ready-to-go `.gitignore` file
sourced from the the .NET Core [.gitignore](https://github.com/dotnet/core/blob/master/.gitignore). This
will help keep your repository clean of build files and other configuration.

Finally, the `.gitlab-ci.yml` contains the configuration needed for GitLab
to build your code. Let's take a look, section by section.

First, we note that we want to use the official Microsoft .NET SDK image
to build our project.

```
image: microsoft/dotnet:latest
```

We're defining two stages here: `build`, and `test`. As your project grows
in complexity you can add more of these.

```
stages:
    - build
    - test
```

Next, we define our build job which simply runs the `dotnet build` command and
identifies the `bin` folder as the output directory. Anything in the `bin` folder
will be automatically handed off to future stages, and is also downloadable through
the web UI.

```
build:
    stage: build
    script:
        - "dotnet build"
    artifacts:
      paths:
        - bin/
```

Similar to the build step, we get our test output simply by running `dotnet test`.

```
test:
    stage: test
    script: 
        - "dotnet test"
```

This should be enough to get you started. There are many, many powerful options 
for your `.gitlab-ci.yml`. You can read about them in our documentation 
[here](https://docs.gitlab.com/ee/ci/yaml/).

test 
