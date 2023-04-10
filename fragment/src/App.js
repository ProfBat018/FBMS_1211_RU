import logo from './logo.svg';
import './App.css';
import {Fragment} from "react";

function App() {

    const data = {
        'users': [
            {
                'id': 1,
                'name': 'John Doe'
            },
            {
                'id': 2,
                'name': 'Jane Doe2'
            },
            {
                'id': 3,
                'name': 'Jane Doe3'
            },
            {
                'id': 4,
                'name': 'Jane Doe4'
            }
        ]
    }

    return data.users.map((user) =>
        (
            <Fragment>
                <div key={user.id}>
                <h1>{user.name}</h1>
                </div>
            </Fragment>
        )
    );
}

export default App;
