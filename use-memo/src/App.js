import logo from './logo.svg';
import './App.css';
import {useState, useMemo} from "react";

const users = [
  {id: '1', Name: 'Elvin'},
  {id: '2', Name: 'Orxan'},
  {id: '3', Name: 'Radjab'},
  {id: '4', Name: 'Kerim'},
  {id: '5', Name: 'Kamran'}
]
function App() {

  const [text, setText] = useState('');
  const [search, setSearch] = useState('');

  const handleText = (param) => {
    console.log('text', text);
    setText(param.target.value)
  }

  const handleSearch = () => {
    setSearch(text);
  };

  const filteredUsers = useMemo(() => users.filter((item) => {
    console.log('filter');
    return item.Name.toLowerCase().includes(search.toLowerCase());
  }), [search]);

  return (
    <div className="App">
    <input value={text} onChange={handleText}/>
    <button onClick={handleSearch}>Search</button>
      <ul>
        {filteredUsers.map((item) => (
            <li key={item.id}>
               {item.Name}
            </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
