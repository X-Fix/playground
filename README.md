# Playground

## Table of Contents

- [Introduction](#introduction)
- [Getting Started](#getting-started)
- [Contributing](#contributing)

## Introduction

This project is intended as a playground/testing space for learning the mechanics of the Unity editor. To that end please ensure the following:

- Where possible, try to group experiments by theme within scenes (but feel free to re-use results in other scenes/experiments)
- Comment the shit out of your code so others can learn from it

The intention is to use the latest and greatest features available so things like the new InputSystem will be preferred/mandatory (depending on backwards compatibility)

## Getting started

### Installing Unity

Make sure you have the latest version of Unity installed (currently 2020.2.2f1)

### Cloning the repository

The simplest way to stay up-to-date with changes and be able to contribute your own work is to clone this repository (don't just download the .zip folder). You can do this with any of the following methods:

-  Download [SourceTree](https://www.sourcetreeapp.com/) and after linking your GitHub account, [follow their instructions](https://confluence.atlassian.com/get-started-with-sourcetree/clone-a-remote-repository-847359098.html) on how to clone a remote repository
- Download [GitHub Desktop](https://desktop.github.com/) and after linking your GitHub account, select the `Open with GitHubDesktop` option from the `Code` dropdown on this repository's main page
- Use Terminal/Command Prompt to clone the repository into the desired folder by runnning the following command
    ```
    git clone https://github.com/X-Fix/playground.git
    ```

## Contributing

Your choice of source control will determine your exact workflow, but regardless of your choice please adhere to the following rules when pushing updates to this repository

- Always create a branch to commit your changes to. Pushing changes to the `main` branch is prohibited as using a branch strategy reduces merge conflicts and keeps changes organised
- Try to keep your changes limited to a single scene per branch/experiment. This will reduce the number of merge conflicts that can occur
- To merge your changes to the main branch, create a PR (pull request) using the template provided

## Todo

May add support for playing with automated build/deploy pipelines, but that may have to wait for a project we actually intend to release for gameplay/testing

P.S. If you don't like my formal README tone you can suck it <3