import { GoogleLogin } from '@react-oauth/google';
import { useNavigate } from 'react-router-dom';

import React from 'react';
import {Navigate, redirect} from "react-router";
import {logDOM} from "@testing-library/react";

const Google = () => {
    const navigate = useNavigate();
    return (
        <GoogleLogin
            onSuccess={credentialResponse => {
                navigate('/news');
            }}
            onError={() => {
                console.log('Login Failed');
            }}
        />

    );
};

export default Google;