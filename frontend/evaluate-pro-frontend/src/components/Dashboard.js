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
                        <td>Box 2</td>
                        <td>Box 3</td>
                        <td>Box 4</td>
                        <td>Box 5</td>
                    </tr>
                    <tr>
                        <td>Conflict Resolution</td>
                        <td>Box 1</td>
                        <td>Box 2</td>
                        <td>Box 3</td>
                        <td>Box 4</td>
                        <td>Box 5</td>
                    </tr>
                    <tr>
                        <td>Task Management</td>
                        <td>Box 1</td>
                        <td>Box 2</td>
                        <td>Box 3</td>
                        <td>Box 4</td>
                        <td>Box 5</td>
                    </tr>
                    <tr>
                        <td>Adapting To Change</td>
                        <td>Box 1</td>
                        <td>Box 2</td>
                        <td>Box 3</td>
                        <td>Box 4</td>
                        <td>Box 5</td>
                    </tr>
                    <tr>
                        <td>Mentoring</td>
                        <td>Box 1</td>
                        <td>Box 2</td>
                        <td>Box 3</td>
                        <td>Box 4</td>
                        <td>Box 5</td>
                    </tr>
                </tbody>
            </table>
            <div className="card max width">
                <div className="container mt 3 ">
                    <div className="btn-group">
                        <button type="button" className="btn btn-primary">Save</button>
                        <button type="button" className="btn btn-primary">Draft</button>
                        <div className="btn-group">
                            <button type="button" className="dropdown-toggle" data-toggle="dropdown" data-bs-toggle="dropdown">Comment</button>
                            <ul className="dropdown-menu">
                                <li><a href="#">Comment 1</a></li>
                                <li><a href="#">Comment 2</a></li>
                                <li><a href="#">Comment 3</a></li>
                            </ul>


                        </div>
                    </div>
                </div>
            </div>
        
      </>
);
}


export default Dashboard;