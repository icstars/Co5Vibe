import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css'; 
const Profile = () => {
  return (
<section style={{ backgroundColor: "#eee",  minHeight: '100vh', width: '100vw'  }}>
  <div className="container-fluid">
    <div className="row">
      <div className="col">
        <nav
          aria-label="breadcrumb"
          className="bg-body-tertiary rounded-3 p-3 mb-4"
        >
          <ol className="breadcrumb mb-0">
            <li className="breadcrumb-item">
              <a href="#">Home</a>
            </li>
            <li className="breadcrumb-item">
              <a href="#">User</a>
            </li>
            <li className="breadcrumb-item active" aria-current="page">
              User Profile
            </li>
          </ol>
        </nav>
      </div>
    </div>
    <div className="row">
      <div className="col-lg-4">
        <div className="card mb-4">
          <div className="card-body text-center">
            <img
              src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-chat/ava3.webp"
              alt="avatar"
              className="rounded-circle img-fluid"
              style={{ width: 150 }}
            />
            <h5 className="my-3">{localStorage.name}</h5>
            <p className="text-muted mb-1">{localStorage.title}</p>
            <p className="text-muted mb-4">{localStorage.address}</p>
            <div className="d-flex justify-content-center mb-2">
              <button
                type="button"
                data-mdb-button-init=""
                data-mdb-ripple-init=""
                className="btn btn-primary"
              >
                Start Assessment
              </button>
              <button
                type="button"
                data-mdb-button-init=""
                data-mdb-ripple-init=""
                className="btn btn-outline-primary ms-1"
              >
                Message
              </button>
            </div>
          </div>
        </div>
        <div className="card mb-4 mb-lg-0">
          <div className="card-body p-0">
            <ul className="list-group list-group-flush rounded-3">
              <li className="list-group-item d-flex justify-content-between align-items-center p-3">
                <i className="fas fa-globe fa-lg text-warning" />
                <p className="mb-0"></p>
              </li>
              <li className="list-group-item d-flex justify-content-between align-items-center p-3">
                <i className="fab fa-github fa-lg text-body" />
                <p className="mb-0"></p>
              </li>
              <li className="list-group-item d-flex justify-content-between align-items-center p-3">
                <i
                  className="fab fa-twitter fa-lg"
                  style={{ color: "#55acee" }}
                />
                <p className="mb-0"></p>
              </li>
              <li className="list-group-item d-flex justify-content-between align-items-center p-3">
                <i
                  className="fab fa-instagram fa-lg"
                  style={{ color: "#ac2bac" }}
                />
                <p className="mb-0"></p>
              </li>
              <li className="list-group-item d-flex justify-content-between align-items-center p-3">
                <i
                  className="fab fa-facebook-f fa-lg"
                  style={{ color: "#3b5998" }}
                />
                <p className="mb-0"></p>
              </li>
            </ul>
          </div>
        </div>
      </div>
      <div className="col-lg-8">
        <div className="card mb-4">
          <div className="card-body">
            <div className="row">
              <div className="col-sm-3">
                <p className="mb-0">Full Name</p>
              </div>
              <div className="col-sm-9">
                <p className="text-muted mb-0">{localStorage.name}</p>
              </div>
            </div>
            <hr />
            <div className="row">
              <div className="col-sm-3">
                <p className="mb-0">Email</p>
              </div>
              <div className="col-sm-9">
                <p className="text-muted mb-0">{localStorage.email}</p>
              </div>
            </div>
            <hr />
            <div className="row">
              <div className="col-sm-3">
                <p className="mb-0">Phone</p>
              </div>
              <div className="col-sm-9">
                <p className="text-muted mb-0">(312) 123-5678</p>
              </div>
            </div>
            <hr />
            <div className="row">
              <div className="col-sm-3">
                <p className="mb-0">Mobile</p>
              </div>
              <div className="col-sm-9">
                <p className="text-muted mb-0">(312) 123-4567</p>
              </div>
            </div>
            <hr />
            <div className="row">
              <div className="col-sm-3">
                <p className="mb-0">Address</p>
              </div>
              <div className="col-sm-9">
                <p className="text-muted mb-0">{localStorage.address}</p>
              </div>
            </div>
          </div>
        </div>
        <div className="row">
          <div className="col-md-6">
            <div className="card mb-4 mb-md-0">
              <div className="card-body">
                <p className="mb-4">
                  <span className="text-primary font-italic me-1">
                    Assessment Progress
                  </span>{" "}
                  
                </p>
                <p className="mb-1" style={{ fontSize: ".77rem" }}>
                  Assessment
                </p>
                <div className="progress rounded" style={{ height: 5 }}>
                  <div
                    className="progress-bar"
                    role="progressbar"
                    style={{ width: "80%" }}
                    aria-valuenow={80}
                    aria-valuemin={0}
                    aria-valuemax={100}
                  />
                </div>
                
                
               
                
              </div>
            </div>
          </div>
          <div className="col-md-6">
            <div className="card mb-4 mb-md-0">
              <div className="card-body">
                <p className="mb-4">
                  <span className="text-primary font-italic me-1">
                    Categories
                  </span>{" "}
                  
                </p>
                <p className="mb-1" style={{ fontSize: ".77rem" }}>
                  Teamwork
                </p>
                <div className="progress rounded" style={{ height: 5 }}>
                  <div
                    className="progress-bar"
                    role="progressbar"
                    style={{ width: "80%" }}
                    aria-valuenow={80}
                    aria-valuemin={0}
                    aria-valuemax={100}
                  />
                </div>
                <p className="mt-4 mb-1" style={{ fontSize: ".77rem" }}>
                  Communication
                </p>
                <div className="progress rounded" style={{ height: 5 }}>
                  <div
                    className="progress-bar"
                    role="progressbar"
                    style={{ width: "72%" }}
                    aria-valuenow={72}
                    aria-valuemin={0}
                    aria-valuemax={100}
                  />
                </div>
                <p className="mt-4 mb-1" style={{ fontSize: ".77rem" }}>
                  Knowledge Application/Problem Solving
                </p>
                <div className="progress rounded" style={{ height: 5 }}>
                  <div
                    className="progress-bar"
                    role="progressbar"
                    style={{ width: "89%" }}
                    aria-valuenow={89}
                    aria-valuemin={0}
                    aria-valuemax={100}
                  />
                </div>
                <p className="mt-4 mb-1" style={{ fontSize: ".77rem" }}>
                Code Aesthetics
                </p>
                <div className="progress rounded" style={{ height: 5 }}>
                  <div
                    className="progress-bar"
                    role="progressbar"
                    style={{ width: "55%" }}
                    aria-valuenow={55}
                    aria-valuemin={0}
                    aria-valuemax={100}
                  />
                </div>
                <p className="mt-4 mb-1" style={{ fontSize: ".77rem" }}>
                  Best Practices
                </p>
                <div className="progress rounded mb-2" style={{ height: 5 }}>
                  <div
                    className="progress-bar"
                    role="progressbar"
                    style={{ width: "66%" }}
                    aria-valuenow={66}
                    aria-valuemin={0}
                    aria-valuemax={100}
                  />
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
  )
}
export default Profile;