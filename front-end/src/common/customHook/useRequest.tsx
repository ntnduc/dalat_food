import { AxiosRequestConfig } from 'axios';
import axios from 'axios';
import { useRef } from 'react';

export interface ApiResponse<T = unknown> {
    success: boolean,
    error?: boolean,
    messsage: string,
    result?: T,
    totalCount?: number,
    [key: string]: unknown
}

interface IUseRequest {
    get: <T = unknown>(url:string, config?: AxiosRequestConfig) => Promise<ApiResponse<T>>,
    post: <T = unknown>(url: string, data: unknown, config?: AxiosRequestConfig) => Promise<ApiResponse<T >>
}

const useRequest = (): IUseRequest => {
    const requestConfig = useRef<AxiosRequestConfig>({
        headers: {
            'content-type': 'application/json; charset=utf-8',
        }
    });

    const post = async<T = unknown>(url: string, data: unknown, config?: AxiosRequestConfig) => {
        const result = await axios.post(url, data, { ...requestConfig, ...config }).then((res: AxiosRequestConfig) => {
            return {
                ...res.data
            } as ApiResponse<T>;
        });
        return result;
    };

    const get = async<T = unknown>(url: string, config?: AxiosRequestConfig) => {
        const result = await axios.get(url, { ...requestConfig.current, ...config }).then((res: AxiosRequestConfig) => {
            return {
                ...res.data
            } as ApiResponse<T>;
        });
        return result;
    };

    return { get, post };
};

export default useRequest;