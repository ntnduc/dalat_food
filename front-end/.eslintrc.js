/* eslint-disable no-undef */
module.exports = {
    env: {
        browser: true,
        es2021: true,
    },
    extends: [
        'eslint:recommended',
        'plugin:react/recommended',
        'plugin:@typescript-eslint/recommended'
    ],
    parser: '@typescript-eslint/parser',
    parserOptions: {
        ecmaFeatures: {jsx: true,},
        ecmaVersion: 'latest',
        sourceType: 'module',
    },
    plugins: ['react', '@typescript-eslint', 'simple-import-sort'],
    rules: {
        '@typescript-eslint/indent': ['error', 4],
        'linebreak-style': 0,
        'global-require': 0,
        'eslint linebreak-style': [0, 'error', process.platform === 'win32' ? 'windows' : 'unix'],
        'quotes': ['warn', 'single'],
        'semi': ['error', 'always'],
        'react/react-in-jsx-scope': 'off',
        'comma-spacing': ['warn', {
            before: false, after: true
        }],
        'no-multi-spaces': 'warn',
        'no-empty-function': 'off',
        '@typescript-eslint/no-empty-function': 'off',
        'simple-import-sort/imports': 'warn',
        'simple-import-sort/exports': 'warn',
        'react/jsx-max-props-per-line': ['warn', { 'maximum': { 'single': 2, 'multi': 1 } }],
        'react/jsx-equals-spacing': ['warn', 'never'],
        'react/jsx-key': ['warn', { 'checkFragmentShorthand': true }],
        'react/jsx-no-useless-fragment': 'warn'

    },
    settings: {react: {version: 'detect',},
        'import/resolver': {
            'node': {
                'extensions': ['.js', '.jsx', '.ts', '.tsx']
            }
        }},
};
