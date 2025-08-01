import React, {useState, useEffect} from 'react'
import axios from 'axios'
import './App.css';

function App() {
  const [members, setMembers] = useState([]);

  useEffect(() => {
    axios
      .get("https://localhost:44313/api/member")
      .then((response) => {
        setMembers(response.data);       
      });
  }, []);

  return (
    <div className="table-wrapper">
      <h3>Üyeler Listesi</h3>
      <table className="member-table">
        <thead>
          <tr>
            <th>ID</th>
            <th>Ad</th>
            <th>Soyad</th>
            <th>Mail</th>
            <th>Üyelik Tarihi</th>
          </tr>
        </thead>
        <tbody>
          {members.map((member) => (
            <tr key={member.ID}>
              <td>{member.ID}</td>
              <td>{member.Name}</td>
              <td>{member.Surname}</td>
              <td>{member.Mail}</td>
              <td>{new Date(member.CreationTime).toLocaleDateString('tr-TR')}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default App;
