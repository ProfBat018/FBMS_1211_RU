
// Class Component

import {useState} from "react";
import {useEffect} from "react";
import './AuthForm.css'


function AuthForm(props) {

    const [username, setUsername] = useState('username');

    let background = props.bg;

    let obj = props;

    useEffect(() => {
        console.log(obj)
    });

    return (
            <div className="form">
                <form>
                    <div className="input-container">
                        <label>{username}</label>
                        <input type="text" name="uname" required />
                    </div>
                    <div className="input-container">
                        <label>Password </label>
                        <input type="password" name="pass" required />
                    </div>
                    <div className="button-container">
                        <input type="submit"/>
                    </div>
                </form>
            </div>
        );
}

// class AuthForm extends Component {
//     constructor() {
//         super();
//         this.foo = this.foo.bind(this);
//     }
//     state = {name: 'aaas'};
//
//     foo() {
//         this.setState({name: 'fdgdgf'});
//     }
//
//     render() {
//         return (
//             <div className="form">
//                 <form>
//                     <div className="input-container">
//                         <label>{this.state.name}</label>
//                         <input type="text" name="uname" required />
//                     </div>
//                     <div className="input-container">
//                         <label>Password </label>
//                         <input type="password" name="pass" required />
//                     </div>
//                     <div className="button-container">
//                         <input type="submit" onClick={this.foo}/>
//                     </div>
//                 </form>
//             </div>
//         );
//     }
// }
export default AuthForm;
