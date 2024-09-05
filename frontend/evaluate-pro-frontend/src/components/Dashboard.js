const Dashboard = () => {
    return (
        <>
            <div className="card max width">
                <div className="card-body">
                    <h1 className="card-title">Welcome to the Dashboard</h1>

                </div>
            </div>
            <table className="table">
                <thead>
                    <tr>
                        <th>Teamwork</th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Collaboration</td>
                        <td>Does not meet expectations</td>
                        <td>Seeks to collaborate with immediate team members or select group of people (mentor, peer developer, another project resource).  Reaches out when thy get stuck on tasks</td>
                        <td>Seeks to collaborate with Small Team regardless of whether the developer shares project work with team members</td>
                        <td>Promotes team cooperation and seeks to collaborate with a larger group (committees, lead developer talk shops, small teams, other departments), and promotes decisions even if different than their own views</td>
                        <td>Identifies and reaches out to peers when they need help and is sought out by peers when they get stuck on tasks.</td>
                    </tr>
                    <tr>
                        <td>Conflict Resolution</td>
                        <td>Does not meet expectations</td>
                        <td>Identifies conflict and reports it to the appropriate party (timely)</td>
                        <td>Identifies conflict and reports it to the appropriate party via appropriate channels, is prepared to offer up relevant information</td>
                        <td>Identifies conflict and reports it to the appropriate party via appropriate channels. Is prepared to offer up relevant information.  Suggests potential solutions.</td>
                        <td>Directly and promptly addresses conflicts while keeping relevant stakeholders in the loop</td>
                    </tr>
                    <tr>
                        <td>Task Management</td>
                        <td>Does not meet expectations</td>
                        <td>Completes tasks as assigned</td>
                        <td>Takes ownership of task completion.  Ensures task is resolved to stakeholder's satisfaction</td>
                        <td>Task efficiency and result exceeds stakeholder's expectations</td>
                        <td>Delegates tasks to team members</td>
                    </tr>
                    <tr>
                        <td>Adapting To Change</td>
                        <td>Does not meet expectations</td>
                        <td>Tolerates change as directed</td>
                        <td>Greets change with a positive attitude</td>
                        <td>Anticipates change and takes steps to personally adapt</td>
                        <td>Assesses changes and takes steps to help others adapt as they occur</td>
                    </tr>
                    <tr>
                        <td>Mentoring</td>
                        <td>Does not meet expectations</td>
                        <td>Remain open and accepting of mentorship from more established peers</td>
                        <td>Seeks out mentorship from peers</td>
                        <td>Supports new team members and helps them adjust to role expectations and team processes</td>
                        <td>Supports peers as a subject matter expert</td>
                    </tr>
                </tbody>
                <div className="card max width">
                <div className="container mt 3">
                    <div className="btn-group">
                        <button type="button" className="btn btn-primary">Save</button>
                        <button type="button" className="btn btn-primary">Draft</button>
                        <div className="btn-group">
                            <button type="button" className="btn btn-primary dropdown-toggle" data-bs-toggle="dropdown">Comment</button>
                            <ul className="dropdown-menu">
                                <li><a className="dropdown-item" href="#"></a></li>
                                <li><a className="dropdown-item" href="#"></a></li>
                                <li><a className="dropdown-item" href="#"></a></li>
                            </ul>


                        </div>
                    </div>
                </div>
            </div>
            </table>
            
            <table className="table">
                <thead>
                    <tr>
                        <th>Communication</th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Engagement</td>
                        <td>Does not meet expectations</td>
                        <td>Is attentive and focused when interacting with others.  Demonstates a positive and patient attitude.  Displays active listening skills.</td>
                        <td>Contributes meaningful discussion when interacting with others</td>
                        <td>Uses follow up communications and actions when necessary to ensure decisions from interactions remain relevant</td>
                        <td>Leads and facilitates discussion.  Keeps topics focused and relevant.</td>
                    </tr>
                    <tr>
                        <td>Verbal Communication</td>
                        <td>Does not meet expectations</td>
                        <td>Communicates clearly to people with similar expertise</td>
                        <td>Chooses correct avenues for communication.  Communicates clearly to a diverse audience including people with whom he or she does not have personal relationship</td>
                        <td>Listens to and understands audience's viewpoint.  Gauges communication strategy to audience's strength and translates techinical concepts into terms he or she will understand when dealing with a non techinical audience</td>
                        <td>Conveys his or her expertise with conviction; however dev is not strident and remains open and accepting of other solutions from others, even when different from his or her own</td>
                    </tr>
                    <tr>
                        <td>Written Communication</td>
                        <td>Does not meet expectations</td>
                        <td>Provides general feedback that is not directly actionable</td>
                        <td>Provides specific actionable feedback through an intermediary</td>
                        <td>Directly provides quality actionable feedback</td>
                        <td>Is aware of context and provides feedback in a timely fashion.  Follows through to validate feedback was received.</td>
                    </tr>
                    <tr>
                        <td>Providing Feedback</td>
                        <td>Does not meet expectations</td>
                        <td>Provides general feedback that is not directly actionable</td>
                        <td>Provides specific actionable feedback through an intermediary</td>
                        <td>Directly provides quality actionable feedback</td>
                        <td>Is aware of context and provides feedback in a timely fashion.  Follows through to validate feedback was received.</td>
                    </tr>
                    <tr>
                        <td>Receiving Feedback</td>
                        <td>Does not meet expectations</td>
                        <td>Receptive to feedback regarding his or her work</td>
                        <td>Able to objectively incorporate feedback in his or her work</td>
                        <td>Understands and accepts the reasoning behind the feedback</td>
                        <td>Understands and accepts the reasoning behind the feedback</td>
                    </tr>
                </tbody>
                <div className="card max width">
                <div className="container mt 3">
                    <div className="btn-group">
                        <button type="button" className="btn btn-primary">Save</button>
                        <button type="button" className="btn btn-primary">Draft</button>
                        <div className="btn-group">
                            <button type="button" className="btn btn-primary dropdown-toggle" data-bs-toggle="dropdown">Comment</button>
                            <ul className="dropdown-menu">
                                <li><a className="dropdown-item" href="#"></a></li>
                                <li><a className="dropdown-item" href="#"></a></li>
                                <li><a className="dropdown-item" href="#"></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            </table>
          
            <table className="table">
                <thead>
                    <tr>
                        <th>Knowledge Application And Problem Solving</th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Strategy and Critcal Thinking Comments</td>
                        <td>Does not meet expectations</td>
                        <td>Has vision of the strategy for feature execution but is not privy to the overall project strategy</td>
                        <td>Has a vision with a solution but may not have considered all of the roadblocks that are likely to occur</td>
                        <td>Has a vision with a solution and has contigency plans for all of the roadblocks that are likely to occur</td>
                        <td>Compares multiple options for how their project works with the client's strategy.  Performs a cost benefit analysis, considers scalability of the project</td>
                    </tr>
                    <tr>
                        <td>Debugging Techniques</td>
                        <td>Does not meet expectations</td>
                        <td>Uses basic debugging techniques with easily accessible tools.  Needs guidance to identify focused area of investigation</td>
                        <td>Uses tools during development to identify likely issues.  Identifies promising areas for focused investigation.</td>
                        <td>Uses scientific method in existing codebase to identiy and solve issues.  Can articulate a hypothesis of the issue.</td>
                        <td>Uses advanced debugging techiniques to analyze code during debugging.  Can create a reduced test case to identify issues.  Understands and uses tools to prevent new issues.</td>
                    </tr>
                    <tr>
                        <td>Tool Selection and Usage</td>
                        <td>Does not meet expectations</td>
                        <td>Uses basic tools for development aids.  Needs guidance for advanced tool usage.  Comfortable with basics in version control and issue tracking.</td>
                        <td>Identifies third-party tools and libraries to aid in project work.  Comfortable with build tools and process.</td>
                        <td>Configures tools in local development environment to streamline efficiency.  Capabale of owning integrations or deployment.</td>
                        <td>Defines strategies surrounding integration, build processes, version control, and issue tracking for project team.</td>
                    </tr>
                                    </tbody>
                                    <div className="card max width">
                <div className="container mt 3">
                    <div className="btn-group">
                        <button type="button" className="btn btn-primary">Save</button>
                        <button type="button" className="btn btn-primary">Draft</button>
                        <div className="btn-group">
                            <button type="button" className="btn btn-primary dropdown-toggle" data-bs-toggle="dropdown">Comment</button>
                            <ul className="dropdown-menu">
                                <li><a className="dropdown-item" href="#"></a></li>
                                <li><a className="dropdown-item" href="#"></a></li>
                                <li><a className="dropdown-item" href="#"></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            </table>
            
            <table className="table">
                <thead>
                    <tr>
                        <th>Code Aesthetics</th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Documentation</td>
                        <td>Does not meet expectations</td>
                        <td>Occasionally uses comments to provide context for ambiguous code</td>
                        <td>Consistently uses comments to provide context for ambiguous code</td>
                        <td>Prepares documentation to assist in project setup and configuration</td>
                        <td>Uses documentation to define the contract between developers on a project.  Understands importance for documenting for various audiences</td>
                    </tr>
                    <tr>
                        <td>Formating Standards</td>
                        <td>Does not meet expectations</td>
                        <td>Occasionally follows the defined code formatting standards</td>
                        <td>Consistently follows the defined code formatting standards</td>
                        <td>Goes beyond the standard and uses code formatting to enhance readability and understanding</td>
                        <td>Can explain most code standards and identify minor deviations from memory without consulting documentation</td>
                    </tr>
                    <tr>
                        <td>Naming</td>
                        <td>Does not meet expectations</td>
                        <td>Regularly defines readable variables and method names that are readable.  Avoids namespace collisions.</td>
                        <td>Defines variable and method names that are readable and accurately describe the intended use or function</td>
                        <td>Selects names that simplify and strongly correspond to terms of art from the problem domain</td>
                        <td>Uses variables and method names to tell the story of an algorithm.  Names inform the units of work that the code is divided into so that a person readin the high level method can understand the intent of smaller portions without drilling into that method</td>
                    </tr>
                    <tr>
                        <td>Syntax and Organization</td>
                        <td>Does not meet expectations</td>
                        <td>Creates code that is syntactically accurate and valid.  Occasionaly creates code following the platform's idiomatic conventions.</td>
                        <td>Creates code following the platform's idiomatic conventions.  File strutcture is organized according to platform conventions</td>
                        <td>Understands when it is appropriate to make an exception to the conventions or validity and can explain why.</td>
                        <td>Consistently creates code following the platform's idiomatic conventions and organizes project structure impeccably.  Can explain reasoning behind conventions.</td>
                    </tr>
                    
                </tbody>
                <div className="card max width">
                <div className="container mt 3">
                    <div className="btn-group">
                        <button type="button" className="btn btn-primary">Save</button>
                        <button type="button" className="btn btn-primary">Draft</button>
                        <div className="btn-group">
                            <button type="button" className="btn btn-primary dropdown-toggle" data-bs-toggle="dropdown">Comment</button>
                            <ul className="dropdown-menu">
                                <li><a className="dropdown-item" href="#"></a></li>
                                <li><a className="dropdown-item" href="#"></a></li>
                                <li><a className="dropdown-item" href="#"></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            </table>
            
            <table className="table">
                <thead>
                    <tr>
                        <th>Best Practices</th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Testing</td>
                        <td>Does not meet expectations</td>
                        <td>Manually tests work. Tests work across targeted platforms during QA phase of project development</td>
                        <td>Tests work across targeted platforms at regular intervals during project development</td>
                        <td>Creates tests and benchmarks that validates handling of failure states in the project. Examples are scaffolding large data sets, running on low power machines, spoofing invalid responses from APIs.</td>
                        <td>Developer has an efficient and optimized testing process for the project.  Developer accurately identifies issues that are out of scope and manages client expectations.</td>
                    </tr>
                    <tr>
                        <td>Refactoring/Readability</td>
                        <td>Does not meet expectations</td>
                        <td>Common code smells are present in the developers code (long methods, large classes, complex conditionals, too many parameters in a single method)</td>
                        <td>Is aware of code smells and can identify problem areas in their code but is unsure how to resolve them.  Knowledge of the formal name is unnecessary</td>
                        <td>Refactors code to remove common code smells on a regular basis</td>
                        <td>Refactors in such a way that the process adds semantic meaning. Assists other developers in identifying and resolving code smells in their projects</td>
                    </tr>
                    <tr>
                        <td>Defensive Programming</td>
                        <td>Does not meet expectations</td>
                        <td>Common code smells are present in the developers code (long methods, large classes, complex conditionals, too many parameters in a single method)</td>
                        <td>Is aware of code smells and can identify problem areas in their code but is unsure how to resolve them.  Knowledge of the formal name is unnecessary</td>
                        <td>Refactors code to remove common code smells on a regular basis</td>
                        <td>Refactors in such a way that the process adds semantic meaning. Assists other developers in identifying and resolving code smells in their projects</td>
                    </tr>
                    <tr>
                        <td>Performance</td>
                        <td>Does not meet expectations</td>
                        <td>Logs errors but does not actively address them in code.  Selects a degree of specificity or visibility that guides other developers to the expected use for the component and defends against unexpected uses.  Does not trust input from users or external systems is safe.</td>
                        <td>Handles all errors, presents relevant information to the user or attempts to gracefully recover.  Writes code with a strategy for managing invalid parameters.</td>
                        <td>Uses platform tools to communicate specific semantic information regarding error cases (custom exceptions or assertions) to guard against "impossible" scenarios during development and testing</td>
                        <td>Identifies and codifies strategies and practices that prevent common errors from recurring on a project</td>
                    </tr>
                    <tr>
                        <td>Security</td>
                        <td>Does not meet expectations</td>
                        <td>Maintains good security hygiene in handling of credentials both his or her own and the client's.  Relies on teamates to ensure security standards in application development</td>
                        <td>Knows and implements discipline-specific security standards</td>
                        <td>Can identify common security issues by sight during code review in another's code.  Recognizes likely sources of fraud.  Validates vital business objectives have been acheieved using trusted sources or sets appropriate client expectations</td>
                        <td>Can articulate benefits of specific security practices to clients and work with client to understand and mitigate security concerns</td>
                    </tr>
                </tbody>
                <div className="card max width">
                <div className="container mt 3">
                    <div className="btn-group">
                        <button type="button" className="btn btn-primary">Save</button>
                        <button type="button" className="btn btn-primary">Draft</button>
                        <div className="btn-group">
                            <button type="button" className="btn btn-primary dropdown-toggle" data-bs-toggle="dropdown">Comment</button>
                            <ul className="dropdown-menu">
                                <li><a className="dropdown-item" href="#"></a></li>
                                <li><a className="dropdown-item" href="#"></a></li>
                                <li><a className="dropdown-item" href="#"></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            </table>
           
        
      </>
);
}


export default Dashboard;