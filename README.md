<<<<<<< HEAD

# bootcamp-fmlx

=======

# Bootcamp

## Getting started

To make it easy for you to get started with GitLab, here's a list of recommended next steps.

Already a pro? Just edit this README.md and make it your own. Want to make it easy? [Use the template at the bottom](#editing-this-readme)!

## Add your files

- [ ] [Create](https://docs.gitlab.com/ee/user/project/repository/web_editor.html#create-a-file) or [upload](https://docs.gitlab.com/ee/user/project/repository/web_editor.html#upload-a-file) files
- [ ] [Add files using the command line](https://docs.gitlab.com/ee/gitlab-basics/add-file.html#add-a-file-using-the-command-line) or push an existing Git repository with the following command:

```
cd existing_repo
git remote add origin https://gitlab.com/shelynurf/bootcamp.git
git branch -M main
git push -uf origin main
```

## Integrate with your tools

- [ ] [Set up project integrations](https://gitlab.com/shelynurf/bootcamp/-/settings/integrations)

## Collaborate with your team

- [ ] [Invite team members and collaborators](https://docs.gitlab.com/ee/user/project/members/)
- [ ] [Create a new merge request](https://docs.gitlab.com/ee/user/project/merge_requests/creating_merge_requests.html)
- [ ] [Automatically close issues from merge requests](https://docs.gitlab.com/ee/user/project/issues/managing_issues.html#closing-issues-automatically)
- [ ] [Enable merge request approvals](https://docs.gitlab.com/ee/user/project/merge_requests/approvals/)
- [ ] [Set auto-merge](https://docs.gitlab.com/ee/user/project/merge_requests/merge_when_pipeline_succeeds.html)

## Test and Deploy

Use the built-in continuous integration in GitLab.

- [ ] [Get started with GitLab CI/CD](https://docs.gitlab.com/ee/ci/quick_start/index.html)
- [ ] [Analyze your code for known vulnerabilities with Static Application Security Testing(SAST)](https://docs.gitlab.com/ee/user/application_security/sast/)
- [ ] [Deploy to Kubernetes, Amazon EC2, or Amazon ECS using Auto Deploy](https://docs.gitlab.com/ee/topics/autodevops/requirements.html)
- [ ] [Use pull-based deployments for improved Kubernetes management](https://docs.gitlab.com/ee/user/clusters/agent/)
- [ ] [Set up protected environments](https://docs.gitlab.com/ee/ci/environments/protected_environments.html)

---

# Pattern Matching

# Collection

## Array

### Array

- access data by index
- fix size
- type safety (cannot add different data type)

### ArrayList (not recommended)

- access data by index
- dynamic size (can add data)
- not type safety

```Arraylist x = new();

```

### `List<T>`

- access data by index
- dynamic size
- type safety

### `HashSet<T>`

- dunamic size
- type safety
- unique(each value is different)

### `LinkedLis<T> (not recommended)`

- good performance (to add/remove item in index)
- type safety
- dynamic size
- bad memory size

# 28/8/2023

## Finalizer / Destructor (not recommended, waste memory)

- nitip ke GC saat bersihin, tolong sekalian lakuin ini
- opponent of constructor -> to destroy instance
- called before GC clean up

## Garbage Collection

- running automatically by time or memory size
- can run manually using Force GC (not reccommended)
- no parameter, access modifier
- same name with class
- handle managed type only(int, string, class, object, dll, not external resource / unmanage type)

- to handling unmanage type, can using

```
Dispose();
```

when Force GC is called, the program wuill stop for ... nano second

```
GC.Collect();
```

# Conditional Compilation

agar bisa compile bagian tertentu saja

```
dotnet build -c namaFolder
```

jika hanya menggunakan

```
dotnet build
```

maka hanya bisa mengcompile debug saja

## Debugger

- searching error
- error : syntax error, logic error

## Hot Reload

- to debug in live


## Hot Reload
- to debug in live
```
watch run
```

## Debug and Trace
Logging -> record activity

Log level :
Trace -> Debug -> Info -> Warning -> Error -> Fatal

Debug and Trace
```
dotnet build
```

Trace
```
dotnet build -c Release
```

# Multithreading
## Deadlock
waiting for each other
solve by : async await, technique
## Race Condition

solve by Lock Mechanism

# File Stream
## File Mode
- create new : create new file, if exist then exception
- create : create new file, if exist then replace
- open : open file. if not found then exception
- open or create : open file, if not found then create new file
- truncate : 
- append : 
