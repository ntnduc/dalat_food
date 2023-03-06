import {AxiosRequestConfig } from 'axios';
import axios from 'axios';
import { useRef } from 'react';

export interface ApiResponse<T = unknown> {
    success: boolean,
    error?: boolean,
    messsage: string,
    result?: T,
    totalCount?: number,
    [key:string]: unknown
}

// interface IUseRequest {
//     get: <T = unknown>(url:string, config?: AxiosRequestConfig) => Promise<ApiResponse<T>>,
//     post: <T = unknown>(url: string, data: unknown, config?: AxiosRequestConfig) => Promise<ApiResponse<T >>
// }

const useRequest = () => {
    const requestConfig = useRef<AxiosRequestConfig>({
        headers: {
            'X-RapidAPI-Key': 'a11148781bmsha5134b594e7a8f4p12061djsn22fb95f0fc12',
            'X-RapidAPI-Host': 'beverages-and-desserts.p.rapidapi.com'
        }
    });

    const post = async<T=unknown>(url: string, data: unknown, config?: AxiosRequestConfig)=>{
        const result = await axios.post(url, data, {...requestConfig, ...config}).then ((res: AxiosRequestConfig): any => {
            return {
                ...res.data
            } as ApiResponse;
        });
        return result;
    };
    
    const get = async<T=unknown>(url: string, config?: AxiosRequestConfig) => {  
        const result = await axios.get(url, {...requestConfig.current, ...config}).then((res: AxiosRequestConfig): any => {
            return {
                ...res.data
            } as ApiResponse;
        });
        return result;
    };

    return {get, post};
};

export default useRequest;