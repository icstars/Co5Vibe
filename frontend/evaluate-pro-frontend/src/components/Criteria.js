// import React,{useEffect, useState} from 'react';
// import axios from 'axios';

// const Criteria = () =>{
//     const [evalCriteria1, setEvalCriteria1]= useState([]);
//     const [evalCriteria2, setEvalCriteria2]= useState([]);
//     const [FName, setFName] = useState('');
// //axios call to fetch criteria1
//     useEffect(() =>{
//         axios.get('https://localhost:5261/api/criteria')
//             .then(response => setEvalCriteria1(response.data))
//             .catch(error => console.error(error))
// //axios call to fetch criteria2            
//     });
//     useEffect(() =>{
//         axios.get('https://localhost:5261/api/criteria')
//             .then(response => setEvalCriteria2(response.data))
//             .catch(error => console.error(error))
//     });
// //axios call to fetch first name
//     useEffect(() =>{
//     axios.get('https://localhost:5261/api/criteria')
//          .then(response=> setFName(response.data))
//          .catch(error => console.error(error))
//     });
// //axios call to post criteria
// const addCriteria = ()=> {
//     axios.post('http://localhost:5261/api/criteria',(FName, evalCriteria1, evalCriteria2))
//          .then(response => setEvalCriteria1([...evalCriteria1,evalCriteria2,FName, response.data]))
//          .catch(error => console.error(error)) 
// };
// return(
//     <div>
//     <h1>Criteria</h1>
//     <ul>
//         (evalCriteria1.map(c=>(
//             <li key={c.id}>{c.FName} {evalCriteria1} {evalCriteria2}</li>
//         )))
//     />
//     <input
//         type='text'
//         placeholder='First Name'
//         value={FName}
//         onChange={e => setFName}(e.target.value)}
//     />
//     </div>
// )

// }