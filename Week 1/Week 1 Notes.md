# SpartaGlobal Week 1 Notes
##### Contents:
- [Powershell](#powershell)
- [Git](#git)
- [Software Development Approaches](#software-development-approaches)
- [Extra Notes](#extra-notes)

## PowerShell
To run a Powershell Script, make sure to set **Execution Policy!**<br>
Before Running: "Set-ExecutionPolicy -scope process -ExecutionPolicy Unrestricted"<br>
After Running: "Set-ExecutionPolicy -scope process -ExecutionPolicy AllSigned"

<u><strong>Commands:</strong></U>
- **Get-ChildItem**
  - Lists all items in directory
  - **Aliases:** gci, ls, dir
  - **Parameters:**
    - "-R" Includes all subfolders
- **Set-Location**
  - Changes directory 
  - **Aliases:** sl, cd, chdir
  - **Parameters:**
    - "..": Moves up by 1 folder
    - "~": Returns to current user's folder
- **Write-Output**
  - Outputs string to console
  - **Aliases:** write, echo
  - **Parameters:**
    - ">>": Outputs to file
- **New-Item**
  - Creates new directory
  - **Aliases:** mkdir, md, ni
- **Get-Content**
  - Outputs file contents
  - **Aliases:** gc, cat

[Back to Top](#SpartaGlobal-Week-1-Notes)

## Git
##### How to commit changes:

1. Navigate to directory in Powershell
    - Login if needed
2. Type "git add [filename]"
   - To add all files, "git add ."
3. Type "git status", make sure everything looks correct
4. Type "git commit -m [changes]"
5. Type "git push"
6. Check if the repository is updated

##### Extras:
- "git reset [version]"
  - Resets your files to the chosen version on GitHub
- "git log"
  - Lists all previous versions
  - Use parameter "--pretty=oneline" to make it easier to read if you have a lot of commits

[Back to Top](#SpartaGlobal-Week-1-Notes)

## Software Development Approaches
### Agile
---
 - **Individuals & Interactions** over Processes & Tools
 - **Working Software** over Comprehensive Documentation
 - **Customer Collaboration** over Contract Negotiation
 - **Responding to Change** over Following a Plan

### Scrum
---
#### Pillars:
- **Transparency**
  - Everyone presents the facts as is & collectively collaborates for the common organisational objective. Nobody has a hidden agenda
- **Inspection**
  - Not done by an inspector, but by everyone on the team. The inspection can be done for the product, processes, people aspects and practices
- **Adaption**
  - Adaption is about contonuous improvement, to adapt based on the results of the inspection. Everyone should reflect on how to improve

#### Roles:
- **Product Owner**
  - Key Stakeholder
  - Deep understanding of the product
  - Communicates with team and shareholders
- **Scrum Master**
  - Keeps team to Scrum values
  - Facilitates meetings
  - Removes impediments
- **Development Team**
  - 3-9 People
  - Decide how the work will be done

#### Gathering Requirements:
**User stories:** As a **\<user type>** I want **\<requirement>** so that **\<result>**<br>
**Epic:** The main story, break down into smaller user stories. Eg. creating a login page: page, credentials, submit<br>
**Three Amigos:** Developer, Tester and Business Analyst discuss user story. Helps to find full required features to implement customer story<br>
**INVEST:** Independent, Negotiable, Valuable, Estimatable, Small, Testable

##### Key Features of a Good User Story:
- User comes first
- Use personas
- Create collaboratively
- Keep your stories simple
- Start with Epics
- Refine story until ready
- Add acceptance criteria
- Use paper cards
- Keep them visible
- They are not everything

##### Example Activity:
**Goal:** I want a website for the local parachuting school, which I run. We're based on a small island in the Netherlands and a lot of the locals are into parachuting<br>
**Task:** I'd like people to know what the weather's like: Wind speed and stuff like that. We get quite a few people drive over to use and then find the cloud is too low to jump<br>

**Epic:** **As a** student, **I want** to know if the weather is good **so that** I can decide whether it is safe to parachute<br>
**User Stories:** 
- As a user, I want to know if the weather conditions are safe for me to go parachuting before I leave, so that I can prevent wasting a journey
- As a user, I want to be able to contact the parachuting school, so that I can double check if it is safe for me to parachute or not
- As an owner, I want to reduce the number of incoming contacts, so that I can respond to the most important ones
- As a user, I want simple icons that explain if the weather is good, ok or bad, so that I don’t need to calculate if the weather conditions are safe by myself

**Acceptance Criteria:**<br>
Checklist of what is required before the User Story is catered for

[Back to Top](#SpartaGlobal-Week-1-Notes)

## Extra Notes
##### Semantic Versioning:
`x.y.z`
- x: Major update
- y: Minor update
- z: Patches

[Back to Top](#SpartaGlobal-Week-1-Notes)
