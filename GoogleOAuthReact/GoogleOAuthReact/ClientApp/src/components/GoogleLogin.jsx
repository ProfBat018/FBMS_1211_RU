import React from 'react';
import {Button, Input} from "reactstrap";
import { GoogleLogin } from '@react-oauth/google';

const GoogleLogin = () => {
    return (
        // <div>
        //     <h1>Auth</h1>
        //     <form method={'POST'} action={"submit"}>
        //         <p>Login</p>
        //         <Input type={"text"} placeholder={"Login"}/>
        //         <p>Password</p>
        //         <Input type={"password"} placeholder={"Password"}/>
        //         <Button style={{"margin-top": "10px"}} type={"submit"} color={"primary"}>Login</Button>
        //     </form>
        //
        //     <form method={'POST'} action={`https://api.domain.com/identity/v1/account/external-login?provider=Google&returnUrl=/home`}>
        //         <Button
        //             type="submit"
        //             name='provider'
        //             value='Google'
        //             title={`Login using Google`}>
        //             <img src={'link-to-google-logo'} alt="" />
        //             Gooogle
        //         </Button>
        //     </form>
        // </div>
        <GoogleLogin
            onSuccess={credentialResponse => {
                console.log(credentialResponse);
            }}
            onError={() => {
                console.log('Login Failed');
            }}
        />
    );
};

export default GoogleLogin;